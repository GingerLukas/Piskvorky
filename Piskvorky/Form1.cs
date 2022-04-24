using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskvorky
{
    public partial class Form1 : Form
    {
        private Player[] _players = new Player[2];
        private EGameState _gameState;

        public EGameState GameState
        {
            get => _gameState;
            set
            {
                _gameState = value;
                OnGameStateChanged(_gameState);
            }
        }

        private EGameMode _gameMode = EGameMode.Mode7x7;

        public EGameMode GameMode
        {
            get => _gameMode;
            set
            {
                _gameMode = value;
                _gameField.GameSize = (int)value;
                _gameField.Invalidate();
            }
        }

        public Form1()
        {
            InitializeComponent();
            _cbGameMode.DataSource = Enum.GetNames(typeof(EGameMode));
            _cbGameMode.SelectedValueChanged += (sender, args) =>
            {
                GameMode = (EGameMode)Enum.Parse(typeof(EGameMode), _cbGameMode.SelectedValue.ToString());
            };
            splitContainer1.Resize += (sender, args) => InvalidateAll();
            splitContainer1.SplitterMoved += (sender, args) => InvalidateAll();
            splitContainer1.SplitterMoving += (sender, args) => InvalidateAll();

            _players[0] = new Player() { Char = "X" };
            _players[1] = new Player() { Char = "O" };

            _gameField.Players = _players;

            _gameField.OnWinner += GameFieldOnOnWinner;

            GameState = EGameState.CreatingPlayers;

            _numRounds.Value = 3;
            _numRounds.Minimum = 3;

            splitContainer1.SplitterWidth = 5;
            _cbGameMode.DropDownStyle = ComboBoxStyle.DropDownList;
            
            UpdateScore();
            UpdateChars();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            splitContainer1.SplitterDistance = Size.Width - 300;
        }

        private void UpdateChars()
        {
            _labelPlayer0Char.Text = _players[0].Char;
            _labelPlayer1Char.Text = _players[1].Char;
        }

        private void SwapChars()
        {
            (_players[0].Char, _players[1].Char) = (_players[1].Char, _players[0].Char);
            UpdateChars();
        }
        
        private void GameFieldOnOnWinner(Player player)
        {
            player.Score++;
            UpdateScore();
            SwapChars();
            _gameField.Clear();
            //check for end of game
            if (_players.Sum(x => x.Score) >= _numRounds.Value)
            {
                MessageBox.Show($"Vyhrál {_players.OrderByDescending(x => x.Score).First().Name}!! gratuluji :)");
                GameState = EGameState.Ended;
                return;
            }

            _gameState = EGameState.Playing;
            InvalidateAll();
        }

        public void InvalidateAll()
        {
            Invalidate();
            _gameField.Invalidate();
        }

        public void DisableAll()
        {
            _gameField.Enabled = false;
            _txtPlayer0.Enabled = false;
            _txtPlayer1.Enabled = false;
            _cbGameMode.Enabled = false;
            _numRounds.Enabled = false;
            _btnConfirmNames.Enabled = false;
            _btnConfirmMode.Enabled = false;
            _btnConfirmRounds.Enabled = false;
            _labelScore.Enabled = false;
        }

        public void OnGameStateChanged(EGameState state)
        {
            DisableAll();
            switch (state)
            {
                case EGameState.CreatingPlayers:
                    _txtPlayer0.Enabled = true;
                    _txtPlayer1.Enabled = true;
                    _btnConfirmNames.Enabled = true;
                    break;
                case EGameState.SelectingMode:
                    _cbGameMode.Enabled = true;
                    _btnConfirmMode.Enabled = true;
                    break;
                case EGameState.Playing:
                    _gameField.Enabled = true;
                    _labelScore.Enabled = true;
                    break;
                case EGameState.SelectingRounds:
                    _numRounds.Enabled = true;
                    _btnConfirmRounds.Enabled = true;
                    break;
                case EGameState.Ended:
                    Application.Exit();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        private void UpdateScore()
        {
            _labelScore.Text = $"{_players[0].Score} : {_players[1].Score}";
        }

        private void _btnConfirmNames_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtPlayer0.Text) || string.IsNullOrWhiteSpace(_txtPlayer1.Text))
            {
                MessageBox.Show("Oba hráči si musí zvolit jméno, takhle by to nešlo hoši :(");
                return;
            }

            _players[0].Name = _txtPlayer0.Text;
            _players[1].Name = _txtPlayer1.Text;

            GameState++;
        }

        private void _btnConfirmMode_Click(object sender, EventArgs e)
        {
            GameState++;
        }

        private void _btnConfirmRounds_Click(object sender, EventArgs e)
        {
            GameState++;
        }
    }
}