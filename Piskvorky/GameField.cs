using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Piskvorky
{
    public partial class GameField : UserControl
    {
        public delegate void OnWinnerHandler(Player player);

        public event OnWinnerHandler OnWinner;
        private int _gameSize;

        public int GameSize
        {
            get => _gameSize;
            set
            {
                _gameArray = new Player[value, value];
                _gameSize = value;
            }
        }

        public Player CurrentPlayer
        {
            get => Players[_playerIndex % Players.Length];
        }

        public Player[] Players { get; set; }

        private int _playerIndex = 0;

        public GameField()
        {
            DoubleBuffered = true;
            GameSize = 7;
            InitializeComponent();
        }

        private Rectangle _rectangle;

        private Player[,] _gameArray;

        protected override void OnResize(EventArgs e)
        {
            //make sure to always draw into right spot after resize
            base.OnResize(e);

            int size = Math.Min(ClientSize.Height, ClientSize.Width);
            _rectangle = new Rectangle(ClientRectangle.X + (ClientRectangle.Width - size) / 2,
                ClientRectangle.Y + (ClientRectangle.Height - size) / 2, size, size);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int size = Math.Min(ClientSize.Height, ClientSize.Width);
            //g.FillRectangle(Brushes.Aqua, _rectangle);

            int step = size / GameSize;

            //draw game board
            for (int x = 0; x < GameSize; x++)
            {
                for (int y = 0; y < GameSize; y++)
                {
                    Rectangle field = new Rectangle(_rectangle.X + x * step, _rectangle.Y + y * step, step, step);
                    g.DrawRectangle(new Pen(Color.Black, 2), field);
                    if (_gameArray[x, y] != null)
                    {
                        //draw already played moves
                        Player p = _gameArray[x, y];
                        g.DrawString(p.Char, Font, p == CurrentPlayer ? Brushes.Green : Brushes.Black, field);
                    }
                    else if(Enabled)
                    {
                        //draw hints on where to play next move
                        g.DrawString(CurrentPlayer.Char, Font, new SolidBrush(Color.FromArgb(67, Color.Black)), field);
                    }
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            //calculate coordinates on pplazing board
            int x = e.X - _rectangle.X;
            int y = e.Y - _rectangle.Y;

            int size = _rectangle.Width / GameSize;

            x /= size;
            y /= size;

            //check for space
            if (_gameArray[x, y] != null)
            {
                MessageBox.Show($"Pole x:{x} y:{y} je již obsazené");
                return;
            }

            //swap active player
            _gameArray[x, y] = CurrentPlayer;
            _playerIndex++;
            _playerIndex %= Players.Length;
            Invalidate();

            //check for winner
            Player winner = GetWinner();
            if (winner != null)
            {
                MessageBox.Show($"Hráč {winner.Name} vyhrál toto kolo!");
                OnWinner?.Invoke(winner);
            }
        }

        public Player GetWinner()
        {
            //sloupce
            for (int x = 0; x < GameSize; x++)
            {
                for (int y = 0; y < GameSize - 3; y++)
                {
                    if (_gameArray[x, y] != null && _gameArray[x, y] == _gameArray[x, y + 1] &&
                        _gameArray[x, y + 2] == _gameArray[x, y + 3] && _gameArray[x, y + 1] == _gameArray[x, y + 2])
                    {
                        return _gameArray[x, y];
                    }
                }
            }

            //radky
            for (int y = 0; y < GameSize; y++)
            {
                for (int x = 0; x < GameSize - 3; x++)
                {
                    if (_gameArray[x, y] != null
                        && _gameArray[x, y] == _gameArray[x + 1, y] && _gameArray[x + 2, y] == _gameArray[x + 3, y] &&
                        _gameArray[x + 1, y] == _gameArray[x + 2, y])
                    {
                        return _gameArray[x, y];
                    }
                }
            }

            //diagonal
            for (int x = 0; x < GameSize - 3; x++)
            {
                for (int y = 0; y < GameSize - 3; y++)
                {
                    if (_gameArray[x, y] != null
                        && _gameArray[x, y] == _gameArray[x + 1, y + 1] &&
                        _gameArray[x + 2, y + 2] == _gameArray[x + 3, y + 3] &&
                        _gameArray[x + 1, y + 1] == _gameArray[x + 2, y + 2])
                    {
                        return _gameArray[x, y];
                    }
                }
            }
            
            for (int x = 3; x < GameSize; x++)
            {
                for (int y = 0; y < GameSize-3; y++)
                {
                    if (_gameArray[x, y] != null
                        && _gameArray[x, y] == _gameArray[x - 1, y + 1] &&
                        _gameArray[x - 2, y + 2] == _gameArray[x - 3, y + 3] &&
                        _gameArray[x - 1, y + 1] == _gameArray[x - 2, y + 2])
                    {
                        return _gameArray[x, y];
                    }
                }
            }

            return null;
        }

        public void Clear()
        {
            //clear game board for another round
            for (int x = 0; x < GameSize; x++)
            {
                for (int y = 0; y < GameSize; y++)
                {
                    _gameArray[x, y] = null;
                }
            }
        }
    }
}