namespace BearGame;

public partial class BearGameProject : Form
{

    #region Constructor
    public BearGameProject()
    {
        InitializeComponent();

        GameViewButton.FlatAppearance.BorderSize = 0;
        GameViewButton.MouseEnter += Buttons_MouseEnter;
        GameViewButton.MouseLeave += Buttons_MouseLeave;
        StatisticsViewButton.FlatAppearance.BorderSize = 0;
        StatisticsViewButton.MouseEnter += Buttons_MouseEnter;
        StatisticsViewButton.MouseLeave += Buttons_MouseLeave;
        StartGameButton.FlatAppearance.BorderSize = 0;
        StartGameButton.MouseEnter += Buttons_MouseEnter;
        StartGameButton.MouseLeave += Buttons_MouseLeave;
        SettingPlayer1.FlatAppearance.BorderSize = 0;
        SettingPlayer1.MouseEnter += Buttons_MouseEnter;
        SettingPlayer1.MouseLeave += Buttons_MouseLeave;
        SettingPlayer2.FlatAppearance.BorderSize = 0;
        SettingPlayer2.MouseEnter += Buttons_MouseEnter;
        SettingPlayer2.MouseLeave += Buttons_MouseLeave;
        SettingPlayer3.FlatAppearance.BorderSize = 0;
        SettingPlayer3.MouseEnter += Buttons_MouseEnter;
        SettingPlayer3.MouseLeave += Buttons_MouseLeave;
        SettingPlayer4.FlatAppearance.BorderSize = 0;
        SettingPlayer4.MouseEnter += Buttons_MouseEnter;
        SettingPlayer4.MouseLeave += Buttons_MouseLeave;
        SaveStatisticsButton.FlatAppearance.BorderSize = 0;
        SaveStatisticsButton.MouseEnter += Buttons_MouseEnter;
        SaveStatisticsButton.MouseLeave += Buttons_MouseLeave;
        LoadStatisticsButton.FlatAppearance.BorderSize = 0;
        LoadStatisticsButton.MouseEnter += Buttons_MouseEnter;
        LoadStatisticsButton.MouseLeave += Buttons_MouseLeave;


        _player1Strategy = new Strategy(true, false, false, true, true, true);
        _player2Strategy = new Strategy(true, false, false, true, true, true);
        _player3Strategy = new Strategy(true, false, false, true, true, true);
        _player4Strategy = new Strategy(true, false, false, true, true, true);

        _dataCollection = null;

    }

    #endregion

    #region GameView

    private void GameViewButton_Click(object sender, EventArgs e)
    {
        StatisticsView.Visible = false;
        StatisticsView.Enabled = false;
        GameView.Visible = true;
        GameView.Enabled = true;
    }

    private void Buttons_MouseEnter(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 1;
            button.BackColor = SystemColors.Highlight;
        }
    }

    private void Buttons_MouseLeave(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = SystemColors.Control;
        }
    }


    #region PlayerSquares

    private TextBox[]? _player1Squares = null;
    private TextBox[]? _player2Squares = null;
    private TextBox[]? _player3Squares = null;
    private TextBox[]? _player4Squares = null;

    public TextBox[] GetPlayer1Squares()
    {
        if (_player1Squares != null)
        {
            return _player1Squares;
        }

        List<TextBox> boxes = new List<TextBox>();
        boxes.Add(YC1);
        boxes.Add(YC2);
        boxes.Add(YC3);
        boxes.Add(YC4);
        boxes.Add(S1);
        boxes.Add(S2);
        boxes.Add(S3);
        boxes.Add(S4);
        boxes.Add(S5);
        boxes.Add(S6);
        boxes.Add(S7);
        boxes.Add(S8);
        boxes.Add(S9);
        boxes.Add(S10);
        boxes.Add(S11);
        boxes.Add(S12);
        boxes.Add(S13);
        boxes.Add(S14);
        boxes.Add(S15);
        boxes.Add(S16);
        boxes.Add(S17);
        boxes.Add(S18);
        boxes.Add(S19);
        boxes.Add(S20);
        boxes.Add(S21);
        boxes.Add(S22);
        boxes.Add(S23);
        boxes.Add(S24);
        boxes.Add(S25);
        boxes.Add(S26);
        boxes.Add(S27);
        boxes.Add(S28);
        boxes.Add(S29);
        boxes.Add(S30);
        boxes.Add(S31);
        boxes.Add(S32);
        boxes.Add(S33);
        boxes.Add(S34);
        boxes.Add(S35);
        boxes.Add(S36);
        boxes.Add(S37);
        boxes.Add(S38);
        boxes.Add(S39);
        boxes.Add(S40);
        boxes.Add(YF1);
        boxes.Add(YF2);
        boxes.Add(YF3);
        boxes.Add(YF4);

        _player1Squares = boxes.ToArray();
        return _player1Squares;
    }

    public TextBox[] GetPlayer2Squares()
    {
        if (_player2Squares != null)
        {
            return _player2Squares;
        }
        List<TextBox> boxes = new List<TextBox>();

        boxes.Add(RC1);
        boxes.Add(RC2);
        boxes.Add(RC3);
        boxes.Add(RC4);
        boxes.Add(S11);
        boxes.Add(S12);
        boxes.Add(S13);
        boxes.Add(S14);
        boxes.Add(S15);
        boxes.Add(S16);
        boxes.Add(S17);
        boxes.Add(S18);
        boxes.Add(S19);
        boxes.Add(S20);
        boxes.Add(S21);
        boxes.Add(S22);
        boxes.Add(S23);
        boxes.Add(S24);
        boxes.Add(S25);
        boxes.Add(S26);
        boxes.Add(S27);
        boxes.Add(S28);
        boxes.Add(S29);
        boxes.Add(S30);
        boxes.Add(S31);
        boxes.Add(S32);
        boxes.Add(S33);
        boxes.Add(S34);
        boxes.Add(S35);
        boxes.Add(S36);
        boxes.Add(S37);
        boxes.Add(S38);
        boxes.Add(S39);
        boxes.Add(S40);
        boxes.Add(S1);
        boxes.Add(S2);
        boxes.Add(S3);
        boxes.Add(S4);
        boxes.Add(S5);
        boxes.Add(S6);
        boxes.Add(S7);
        boxes.Add(S8);
        boxes.Add(S9);
        boxes.Add(S10);
        boxes.Add(RF1);
        boxes.Add(RF2);
        boxes.Add(RF3);
        boxes.Add(RF4);

        _player2Squares = boxes.ToArray();
        return _player2Squares;
    }

    public TextBox[] GetPlayer3Squares()
    {
        if (_player3Squares != null)
        {
            return _player3Squares;
        }
        List<TextBox> boxes = new List<TextBox>();
        boxes.Add(BC1);
        boxes.Add(BC2);
        boxes.Add(BC3);
        boxes.Add(BC4);
        boxes.Add(S21);
        boxes.Add(S22);
        boxes.Add(S23);
        boxes.Add(S24);
        boxes.Add(S25);
        boxes.Add(S26);
        boxes.Add(S27);
        boxes.Add(S28);
        boxes.Add(S29);
        boxes.Add(S30);
        boxes.Add(S31);
        boxes.Add(S32);
        boxes.Add(S33);
        boxes.Add(S34);
        boxes.Add(S35);
        boxes.Add(S36);
        boxes.Add(S37);
        boxes.Add(S38);
        boxes.Add(S39);
        boxes.Add(S40);
        boxes.Add(S1);
        boxes.Add(S2);
        boxes.Add(S3);
        boxes.Add(S4);
        boxes.Add(S5);
        boxes.Add(S6);
        boxes.Add(S7);
        boxes.Add(S8);
        boxes.Add(S9);
        boxes.Add(S10);
        boxes.Add(S11);
        boxes.Add(S12);
        boxes.Add(S13);
        boxes.Add(S14);
        boxes.Add(S15);
        boxes.Add(S16);
        boxes.Add(S17);
        boxes.Add(S18);
        boxes.Add(S19);
        boxes.Add(S20);
        boxes.Add(BF1);
        boxes.Add(BF2);
        boxes.Add(BF3);
        boxes.Add(BF4);
        _player3Squares = boxes.ToArray();
        return _player3Squares;
    }

    public TextBox[] GetPlayer4Squares()
    {
        if (_player4Squares != null)
        {
            return _player4Squares;
        }
        List<TextBox> boxes = new List<TextBox>();
        boxes.Add(GC1);
        boxes.Add(GC2);
        boxes.Add(GC3);
        boxes.Add(GC4);
        boxes.Add(S31);
        boxes.Add(S32);
        boxes.Add(S33);
        boxes.Add(S34);
        boxes.Add(S35);
        boxes.Add(S36);
        boxes.Add(S37);
        boxes.Add(S38);
        boxes.Add(S39);
        boxes.Add(S40);
        boxes.Add(S1);
        boxes.Add(S2);
        boxes.Add(S3);
        boxes.Add(S4);
        boxes.Add(S5);
        boxes.Add(S6);
        boxes.Add(S7);
        boxes.Add(S8);
        boxes.Add(S9);
        boxes.Add(S10);
        boxes.Add(S11);
        boxes.Add(S12);
        boxes.Add(S13);
        boxes.Add(S14);
        boxes.Add(S15);
        boxes.Add(S16);
        boxes.Add(S17);
        boxes.Add(S18);
        boxes.Add(S19);
        boxes.Add(S20);
        boxes.Add(S21);
        boxes.Add(S22);
        boxes.Add(S23);
        boxes.Add(S24);
        boxes.Add(S25);
        boxes.Add(S26);
        boxes.Add(S27);
        boxes.Add(S28);
        boxes.Add(S29);
        boxes.Add(S30);
        boxes.Add(GF1);
        boxes.Add(GF2);
        boxes.Add(GF3);
        boxes.Add(GF4);
        _player4Squares = boxes.ToArray();
        return _player4Squares;
    }

    #endregion

    public Player[] GetPlayers(int numberOfPlayers)
    {
        if (numberOfPlayers < 2 || numberOfPlayers > 4)
        {
            throw new ArgumentException("Invalid number of players");
        }

        Player[] players = new Player[numberOfPlayers];

        for (int i = 0; i < numberOfPlayers; i++)
        {
            switch (i)
            {
                case 0:
                    players[i] = new Player(Color.Yellow, GetPlayer1Squares(), _player1Strategy, i);
                    break;
                case 1:
                    players[i] = new Player(Color.Red, GetPlayer2Squares(), _player2Strategy, i);
                    break;
                case 2:
                    players[i] = new Player(Color.Blue, GetPlayer3Squares(), _player3Strategy, i);
                    break;
                case 3:
                    players[i] = new Player(Color.Green, GetPlayer4Squares(), _player4Strategy, i);
                    break;
            }
        }
        return players;
    }

    private void SetVisibilityWhileSimulating(bool visibility)
    {
        StartGameButton.Enabled = visibility;
        NumberOfPlayersSelector.Enabled = visibility;
        NumberOfMatchesSelector.Enabled = visibility;
        SettingPlayer1.Enabled = visibility;
        SettingPlayer2.Enabled = visibility;
        SettingPlayer3.Enabled = visibility;
        SettingPlayer4.Enabled = visibility;
        SaveStatisticsButton.Enabled = visibility;
        SaveStatisticsButton.Visible = visibility;
        LoadStatisticsButton.Enabled = visibility;
        LoadStatisticsButton.Visible = visibility;

        StartGameButton.UseWaitCursor = !visibility;
        ProgressPanel.Visible = !visibility;
    }

    private async void StartGAmeButton_Click(object sender, EventArgs e)
    {
        try
        {
            GameStatistics gameStatistics = new GameStatistics((int)NumberOfMatchesSelector.Value, (int)NumberOfPlayersSelector.Value);
            _dataCollection = new DataCollection(gameStatistics);
            Player[] players = GetPlayers((int)NumberOfPlayersSelector.Value);

            foreach (Player player in players)
            {
                gameStatistics.PlayerStrategies.Add(player.PlayerStrategy);
            }

            Game game = new Game(players, UseSlowModeBox, GameSpeedBar, SimulationProgress, ProgressLabel, gameStatistics.MatchStatistics, MatchesPlayedCounter, RoundsPlayedCounter, PlayerFinishedCounter);
            string tempText = StartGameButton.Text;
            StartGameButton.Text = "GameIsRunning...";
            SimulationProgress.Value = 0;
            SetVisibilityWhileSimulating(false);

            await game.StartGame((int)NumberOfMatchesSelector.Value);

            SetVisibilityWhileSimulating(true);
            StartGameButton.Text = tempText;
            MatchesPlayedCounter.Text = "0";
            RoundsPlayedCounter.Text = "0";
            PlayerFinishedCounter.Text = "0";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void NumberOfPlayersSelector_ValueChanged(object sender, EventArgs e)
    {
        if (NumberOfPlayersSelector.Value <= 2)
        {
            SettingPlayer3.Visible = false;
            SettingPlayer3.Enabled = false;
            SettingPlayer4.Visible = false;
            SettingPlayer4.Enabled = false;
        }
        else if (NumberOfPlayersSelector.Value == 3)
        {

            SettingPlayer3.Visible = true;
            SettingPlayer3.Enabled = true;
            SettingPlayer4.Visible = false;
            SettingPlayer4.Enabled = false;
        }
        else
        {
            SettingPlayer3.Visible = true;
            SettingPlayer3.Enabled = true;
            SettingPlayer4.Visible = true;
            SettingPlayer4.Enabled = true;
        }
    }

    private Strategy _player1Strategy;
    private Strategy _player2Strategy;
    private Strategy _player3Strategy;
    private Strategy _player4Strategy;

    private void SettingPlayer1_Click(object sender, EventArgs e)
    {
        _player1Strategy = GetPlayerStrategy(_player1Strategy, SettingPlayer1.ForeColor);
    }

    private void SettingPlayer2_Click(object sender, EventArgs e)
    {
        _player2Strategy = GetPlayerStrategy(_player2Strategy, SettingPlayer2.ForeColor);
    }

    private void SettingPlayer3_Click(object sender, EventArgs e)
    {
        _player3Strategy = GetPlayerStrategy(_player3Strategy, SettingPlayer3.ForeColor);
    }

    private void SettingPlayer4_Click(object sender, EventArgs e)
    {
        _player4Strategy = GetPlayerStrategy(_player4Strategy, SettingPlayer4.ForeColor);
    }

    private Strategy GetPlayerStrategy(Strategy currentStrategy, Color playerColor)
    {
        try
        {
            PlayerSettings playerSettings = new PlayerSettings(currentStrategy, playerColor);
            var result = playerSettings.ShowDialog();
            if (result == DialogResult.OK)
            {
                return playerSettings.PlayerStrategy;
            }
            playerSettings.Dispose();
            return currentStrategy;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return currentStrategy;
        }

    }

    private void UseSlowModeBox_CheckedChanged(object sender, EventArgs e)
    {
        GameSpeedBar.Enabled = UseSlowModeBox.Checked;
    }

    #endregion

    #region Statistics

    private DataCollection? _dataCollection;

    private void StatisticsViewButton_Click(object sender, EventArgs e)
    {
        GameView.Visible = false;
        GameView.Enabled = false;
        StatisticsView.Visible = true;
        StatisticsView.Enabled = true;
    }

    private void SaveStatisticsButton_Click(object sender, EventArgs e)
    {
        if (_dataCollection != null)
        {
            try
            {
                var saveFile = new SaveFileDialog();
                var result = saveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _dataCollection.JsonFilePath = saveFile.FileName;
                    _dataCollection.SaveGameStatistics();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void LoadStatisticsButton_Click(object sender, EventArgs e)
    {
        try
        {
           if (_dataCollection == null)
            {
                _dataCollection = new DataCollection();
            }

           var openFile = new OpenFileDialog();
            var result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                _dataCollection.JsonFilePath = openFile.FileName;
                _dataCollection.LoadGameStatistics();
                SaveStatisticsButton.Enabled = true;
                SaveStatisticsButton.Visible = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    #endregion
}