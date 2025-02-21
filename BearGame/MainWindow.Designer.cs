﻿namespace BearGame
{
    partial class BearGameProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ViewControlPanel = new Panel();
            StatisticsViewButton = new Button();
            GameViewButton = new Button();
            GameView = new Panel();
            GameTablePanel = new Panel();
            GF4 = new TextBox();
            GF3 = new TextBox();
            GF2 = new TextBox();
            GF1 = new TextBox();
            BF4 = new TextBox();
            BF3 = new TextBox();
            BF2 = new TextBox();
            BF1 = new TextBox();
            RF4 = new TextBox();
            RF3 = new TextBox();
            RF2 = new TextBox();
            RF1 = new TextBox();
            YF4 = new TextBox();
            YF3 = new TextBox();
            YF2 = new TextBox();
            YF1 = new TextBox();
            S36 = new TextBox();
            S37 = new TextBox();
            S35 = new TextBox();
            S38 = new TextBox();
            S34 = new TextBox();
            S39 = new TextBox();
            S33 = new TextBox();
            S40 = new TextBox();
            S32 = new TextBox();
            S16 = new TextBox();
            S17 = new TextBox();
            S15 = new TextBox();
            S18 = new TextBox();
            S14 = new TextBox();
            S13 = new TextBox();
            S19 = new TextBox();
            S20 = new TextBox();
            S12 = new TextBox();
            S26 = new TextBox();
            S25 = new TextBox();
            S27 = new TextBox();
            S24 = new TextBox();
            S28 = new TextBox();
            S29 = new TextBox();
            S23 = new TextBox();
            S22 = new TextBox();
            S30 = new TextBox();
            S21 = new TextBox();
            S31 = new TextBox();
            S6 = new TextBox();
            S7 = new TextBox();
            S5 = new TextBox();
            S8 = new TextBox();
            S4 = new TextBox();
            S3 = new TextBox();
            S9 = new TextBox();
            S10 = new TextBox();
            S2 = new TextBox();
            S11 = new TextBox();
            S1 = new TextBox();
            BC3 = new TextBox();
            BC4 = new TextBox();
            BC2 = new TextBox();
            BC1 = new TextBox();
            GC3 = new TextBox();
            GC4 = new TextBox();
            GC2 = new TextBox();
            GC1 = new TextBox();
            RC3 = new TextBox();
            RC4 = new TextBox();
            RC2 = new TextBox();
            RC1 = new TextBox();
            YC4 = new TextBox();
            YC3 = new TextBox();
            YC2 = new TextBox();
            YC1 = new TextBox();
            GameConfigPanel = new Panel();
            SettingPlayer4 = new Button();
            SettingPlayer3 = new Button();
            SettingPlayer2 = new Button();
            SettingPlayer1 = new Button();
            GameStrategyLabel = new Label();
            NumberOfMatchesSelector = new NumericUpDown();
            NumberOfMatchesLabel = new Label();
            NumberOfPlayersSelector = new NumericUpDown();
            NumberOfPlayersLabel = new Label();
            StartGAmeButton = new Button();
            GameConfigLabel = new Label();
            ViewControlPanel.SuspendLayout();
            GameView.SuspendLayout();
            GameTablePanel.SuspendLayout();
            GameConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberOfMatchesSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPlayersSelector).BeginInit();
            SuspendLayout();
            // 
            // ViewControlPanel
            // 
            ViewControlPanel.BackColor = SystemColors.Control;
            ViewControlPanel.BorderStyle = BorderStyle.FixedSingle;
            ViewControlPanel.Controls.Add(StatisticsViewButton);
            ViewControlPanel.Controls.Add(GameViewButton);
            ViewControlPanel.Dock = DockStyle.Top;
            ViewControlPanel.Location = new Point(0, 0);
            ViewControlPanel.Margin = new Padding(4);
            ViewControlPanel.Name = "ViewControlPanel";
            ViewControlPanel.Size = new Size(1900, 41);
            ViewControlPanel.TabIndex = 0;
            // 
            // StatisticsViewButton
            // 
            StatisticsViewButton.Dock = DockStyle.Left;
            StatisticsViewButton.FlatStyle = FlatStyle.Flat;
            StatisticsViewButton.Location = new Point(210, 0);
            StatisticsViewButton.Margin = new Padding(4);
            StatisticsViewButton.Name = "StatisticsViewButton";
            StatisticsViewButton.Size = new Size(210, 39);
            StatisticsViewButton.TabIndex = 2;
            StatisticsViewButton.Text = "StatisticsView";
            StatisticsViewButton.UseVisualStyleBackColor = true;
            // 
            // GameViewButton
            // 
            GameViewButton.Dock = DockStyle.Left;
            GameViewButton.FlatStyle = FlatStyle.Flat;
            GameViewButton.Location = new Point(0, 0);
            GameViewButton.Margin = new Padding(4);
            GameViewButton.Name = "GameViewButton";
            GameViewButton.Size = new Size(210, 39);
            GameViewButton.TabIndex = 1;
            GameViewButton.Text = "GameView";
            GameViewButton.UseVisualStyleBackColor = true;
            GameViewButton.Click += GameViewButton_Click;
            // 
            // GameView
            // 
            GameView.Controls.Add(GameTablePanel);
            GameView.Controls.Add(GameConfigPanel);
            GameView.Dock = DockStyle.Fill;
            GameView.Location = new Point(0, 41);
            GameView.Margin = new Padding(4);
            GameView.Name = "GameView";
            GameView.Size = new Size(1900, 744);
            GameView.TabIndex = 1;
            // 
            // GameTablePanel
            // 
            GameTablePanel.BorderStyle = BorderStyle.FixedSingle;
            GameTablePanel.Controls.Add(GF4);
            GameTablePanel.Controls.Add(GF3);
            GameTablePanel.Controls.Add(GF2);
            GameTablePanel.Controls.Add(GF1);
            GameTablePanel.Controls.Add(BF4);
            GameTablePanel.Controls.Add(BF3);
            GameTablePanel.Controls.Add(BF2);
            GameTablePanel.Controls.Add(BF1);
            GameTablePanel.Controls.Add(RF4);
            GameTablePanel.Controls.Add(RF3);
            GameTablePanel.Controls.Add(RF2);
            GameTablePanel.Controls.Add(RF1);
            GameTablePanel.Controls.Add(YF4);
            GameTablePanel.Controls.Add(YF3);
            GameTablePanel.Controls.Add(YF2);
            GameTablePanel.Controls.Add(YF1);
            GameTablePanel.Controls.Add(S36);
            GameTablePanel.Controls.Add(S37);
            GameTablePanel.Controls.Add(S35);
            GameTablePanel.Controls.Add(S38);
            GameTablePanel.Controls.Add(S34);
            GameTablePanel.Controls.Add(S39);
            GameTablePanel.Controls.Add(S33);
            GameTablePanel.Controls.Add(S40);
            GameTablePanel.Controls.Add(S32);
            GameTablePanel.Controls.Add(S16);
            GameTablePanel.Controls.Add(S17);
            GameTablePanel.Controls.Add(S15);
            GameTablePanel.Controls.Add(S18);
            GameTablePanel.Controls.Add(S14);
            GameTablePanel.Controls.Add(S13);
            GameTablePanel.Controls.Add(S19);
            GameTablePanel.Controls.Add(S20);
            GameTablePanel.Controls.Add(S12);
            GameTablePanel.Controls.Add(S26);
            GameTablePanel.Controls.Add(S25);
            GameTablePanel.Controls.Add(S27);
            GameTablePanel.Controls.Add(S24);
            GameTablePanel.Controls.Add(S28);
            GameTablePanel.Controls.Add(S29);
            GameTablePanel.Controls.Add(S23);
            GameTablePanel.Controls.Add(S22);
            GameTablePanel.Controls.Add(S30);
            GameTablePanel.Controls.Add(S21);
            GameTablePanel.Controls.Add(S31);
            GameTablePanel.Controls.Add(S6);
            GameTablePanel.Controls.Add(S7);
            GameTablePanel.Controls.Add(S5);
            GameTablePanel.Controls.Add(S8);
            GameTablePanel.Controls.Add(S4);
            GameTablePanel.Controls.Add(S3);
            GameTablePanel.Controls.Add(S9);
            GameTablePanel.Controls.Add(S10);
            GameTablePanel.Controls.Add(S2);
            GameTablePanel.Controls.Add(S11);
            GameTablePanel.Controls.Add(S1);
            GameTablePanel.Controls.Add(BC3);
            GameTablePanel.Controls.Add(BC4);
            GameTablePanel.Controls.Add(BC2);
            GameTablePanel.Controls.Add(BC1);
            GameTablePanel.Controls.Add(GC3);
            GameTablePanel.Controls.Add(GC4);
            GameTablePanel.Controls.Add(GC2);
            GameTablePanel.Controls.Add(GC1);
            GameTablePanel.Controls.Add(RC3);
            GameTablePanel.Controls.Add(RC4);
            GameTablePanel.Controls.Add(RC2);
            GameTablePanel.Controls.Add(RC1);
            GameTablePanel.Controls.Add(YC4);
            GameTablePanel.Controls.Add(YC3);
            GameTablePanel.Controls.Add(YC2);
            GameTablePanel.Controls.Add(YC1);
            GameTablePanel.Dock = DockStyle.Fill;
            GameTablePanel.Location = new Point(0, 0);
            GameTablePanel.Margin = new Padding(4);
            GameTablePanel.Name = "GameTablePanel";
            GameTablePanel.Size = new Size(1552, 744);
            GameTablePanel.TabIndex = 1;
            // 
            // GF4
            // 
            GF4.BackColor = SystemColors.Control;
            GF4.BorderStyle = BorderStyle.FixedSingle;
            GF4.Enabled = false;
            GF4.ForeColor = Color.White;
            GF4.Location = new Point(499, 346);
            GF4.Margin = new Padding(4);
            GF4.Name = "GF4";
            GF4.ReadOnly = true;
            GF4.Size = new Size(33, 31);
            GF4.TabIndex = 71;
            GF4.Tag = "";
            GF4.Text = "F";
            GF4.TextAlign = HorizontalAlignment.Center;
            // 
            // GF3
            // 
            GF3.BackColor = SystemColors.Control;
            GF3.BorderStyle = BorderStyle.FixedSingle;
            GF3.Enabled = false;
            GF3.ForeColor = Color.White;
            GF3.Location = new Point(499, 401);
            GF3.Margin = new Padding(4);
            GF3.Name = "GF3";
            GF3.ReadOnly = true;
            GF3.Size = new Size(33, 31);
            GF3.TabIndex = 70;
            GF3.Tag = "";
            GF3.Text = "F";
            GF3.TextAlign = HorizontalAlignment.Center;
            // 
            // GF2
            // 
            GF2.BackColor = SystemColors.Control;
            GF2.BorderStyle = BorderStyle.FixedSingle;
            GF2.Enabled = false;
            GF2.ForeColor = Color.White;
            GF2.Location = new Point(499, 452);
            GF2.Margin = new Padding(4);
            GF2.Name = "GF2";
            GF2.ReadOnly = true;
            GF2.Size = new Size(33, 31);
            GF2.TabIndex = 69;
            GF2.Tag = "";
            GF2.Text = "F";
            GF2.TextAlign = HorizontalAlignment.Center;
            // 
            // GF1
            // 
            GF1.BackColor = SystemColors.Control;
            GF1.BorderStyle = BorderStyle.FixedSingle;
            GF1.Enabled = false;
            GF1.ForeColor = Color.White;
            GF1.Location = new Point(499, 506);
            GF1.Margin = new Padding(4);
            GF1.Name = "GF1";
            GF1.ReadOnly = true;
            GF1.Size = new Size(33, 31);
            GF1.TabIndex = 68;
            GF1.Tag = "";
            GF1.Text = "F";
            GF1.TextAlign = HorizontalAlignment.Center;
            // 
            // BF4
            // 
            BF4.BackColor = SystemColors.Control;
            BF4.BorderStyle = BorderStyle.FixedSingle;
            BF4.Enabled = false;
            BF4.ForeColor = Color.White;
            BF4.Location = new Point(1035, 495);
            BF4.Margin = new Padding(4);
            BF4.Name = "BF4";
            BF4.ReadOnly = true;
            BF4.Size = new Size(33, 31);
            BF4.TabIndex = 67;
            BF4.Tag = "";
            BF4.Text = "F";
            BF4.TextAlign = HorizontalAlignment.Center;
            // 
            // BF3
            // 
            BF3.BackColor = SystemColors.Control;
            BF3.BorderStyle = BorderStyle.FixedSingle;
            BF3.Enabled = false;
            BF3.ForeColor = Color.White;
            BF3.Location = new Point(1101, 495);
            BF3.Margin = new Padding(4);
            BF3.Name = "BF3";
            BF3.ReadOnly = true;
            BF3.Size = new Size(33, 31);
            BF3.TabIndex = 66;
            BF3.Tag = "";
            BF3.Text = "F";
            BF3.TextAlign = HorizontalAlignment.Center;
            // 
            // BF2
            // 
            BF2.BackColor = SystemColors.Control;
            BF2.BorderStyle = BorderStyle.FixedSingle;
            BF2.Enabled = false;
            BF2.ForeColor = Color.White;
            BF2.Location = new Point(1186, 495);
            BF2.Margin = new Padding(4);
            BF2.Name = "BF2";
            BF2.ReadOnly = true;
            BF2.Size = new Size(33, 31);
            BF2.TabIndex = 65;
            BF2.Tag = "";
            BF2.Text = "F";
            BF2.TextAlign = HorizontalAlignment.Center;
            // 
            // BF1
            // 
            BF1.BackColor = SystemColors.Control;
            BF1.BorderStyle = BorderStyle.FixedSingle;
            BF1.Enabled = false;
            BF1.ForeColor = Color.White;
            BF1.Location = new Point(1274, 495);
            BF1.Margin = new Padding(4);
            BF1.Name = "BF1";
            BF1.ReadOnly = true;
            BF1.Size = new Size(33, 31);
            BF1.TabIndex = 64;
            BF1.Tag = "";
            BF1.Text = "F";
            BF1.TextAlign = HorizontalAlignment.Center;
            // 
            // RF4
            // 
            RF4.BackColor = SystemColors.Control;
            RF4.BorderStyle = BorderStyle.FixedSingle;
            RF4.Enabled = false;
            RF4.ForeColor = Color.White;
            RF4.Location = new Point(1186, 381);
            RF4.Margin = new Padding(4);
            RF4.Name = "RF4";
            RF4.ReadOnly = true;
            RF4.Size = new Size(33, 31);
            RF4.TabIndex = 63;
            RF4.Tag = "";
            RF4.Text = "F";
            RF4.TextAlign = HorizontalAlignment.Center;
            // 
            // RF3
            // 
            RF3.BackColor = SystemColors.Control;
            RF3.BorderStyle = BorderStyle.FixedSingle;
            RF3.Enabled = false;
            RF3.ForeColor = Color.White;
            RF3.Location = new Point(1186, 320);
            RF3.Margin = new Padding(4);
            RF3.Name = "RF3";
            RF3.ReadOnly = true;
            RF3.Size = new Size(33, 31);
            RF3.TabIndex = 62;
            RF3.Tag = "";
            RF3.Text = "F";
            RF3.TextAlign = HorizontalAlignment.Center;
            // 
            // RF2
            // 
            RF2.BackColor = SystemColors.Control;
            RF2.BorderStyle = BorderStyle.FixedSingle;
            RF2.Enabled = false;
            RF2.ForeColor = Color.White;
            RF2.Location = new Point(1186, 262);
            RF2.Margin = new Padding(4);
            RF2.Name = "RF2";
            RF2.ReadOnly = true;
            RF2.Size = new Size(33, 31);
            RF2.TabIndex = 61;
            RF2.Tag = "";
            RF2.Text = "F";
            RF2.TextAlign = HorizontalAlignment.Center;
            // 
            // RF1
            // 
            RF1.BackColor = SystemColors.Control;
            RF1.BorderStyle = BorderStyle.FixedSingle;
            RF1.Enabled = false;
            RF1.ForeColor = Color.White;
            RF1.Location = new Point(1186, 204);
            RF1.Margin = new Padding(4);
            RF1.Name = "RF1";
            RF1.ReadOnly = true;
            RF1.Size = new Size(33, 31);
            RF1.TabIndex = 60;
            RF1.Tag = "";
            RF1.Text = "F";
            RF1.TextAlign = HorizontalAlignment.Center;
            // 
            // YF4
            // 
            YF4.BackColor = SystemColors.Control;
            YF4.BorderStyle = BorderStyle.FixedSingle;
            YF4.Enabled = false;
            YF4.ForeColor = Color.White;
            YF4.Location = new Point(650, 245);
            YF4.Margin = new Padding(4);
            YF4.Name = "YF4";
            YF4.ReadOnly = true;
            YF4.Size = new Size(33, 31);
            YF4.TabIndex = 59;
            YF4.Tag = "";
            YF4.Text = "F";
            YF4.TextAlign = HorizontalAlignment.Center;
            // 
            // YF3
            // 
            YF3.BackColor = SystemColors.Control;
            YF3.BorderStyle = BorderStyle.FixedSingle;
            YF3.Enabled = false;
            YF3.ForeColor = Color.White;
            YF3.Location = new Point(571, 245);
            YF3.Margin = new Padding(4);
            YF3.Name = "YF3";
            YF3.ReadOnly = true;
            YF3.Size = new Size(33, 31);
            YF3.TabIndex = 58;
            YF3.Tag = "";
            YF3.Text = "F";
            YF3.TextAlign = HorizontalAlignment.Center;
            // 
            // YF2
            // 
            YF2.BackColor = SystemColors.Control;
            YF2.BorderStyle = BorderStyle.FixedSingle;
            YF2.Enabled = false;
            YF2.ForeColor = Color.White;
            YF2.Location = new Point(499, 245);
            YF2.Margin = new Padding(4);
            YF2.Name = "YF2";
            YF2.ReadOnly = true;
            YF2.Size = new Size(33, 31);
            YF2.TabIndex = 57;
            YF2.Tag = "";
            YF2.Text = "F";
            YF2.TextAlign = HorizontalAlignment.Center;
            // 
            // YF1
            // 
            YF1.BackColor = SystemColors.Control;
            YF1.BorderStyle = BorderStyle.FixedSingle;
            YF1.Enabled = false;
            YF1.ForeColor = Color.White;
            YF1.Location = new Point(412, 245);
            YF1.Margin = new Padding(4);
            YF1.Name = "YF1";
            YF1.ReadOnly = true;
            YF1.Size = new Size(33, 31);
            YF1.TabIndex = 56;
            YF1.Tag = "";
            YF1.Text = "F";
            YF1.TextAlign = HorizontalAlignment.Center;
            // 
            // S36
            // 
            S36.BackColor = SystemColors.Control;
            S36.BorderStyle = BorderStyle.FixedSingle;
            S36.Enabled = false;
            S36.ForeColor = Color.Black;
            S36.Location = new Point(160, 369);
            S36.Margin = new Padding(4);
            S36.Name = "S36";
            S36.ReadOnly = true;
            S36.Size = new Size(33, 31);
            S36.TabIndex = 55;
            S36.Tag = "";
            S36.TextAlign = HorizontalAlignment.Center;
            // 
            // S37
            // 
            S37.BackColor = SystemColors.Control;
            S37.BorderStyle = BorderStyle.FixedSingle;
            S37.Enabled = false;
            S37.ForeColor = Color.Black;
            S37.Location = new Point(160, 311);
            S37.Margin = new Padding(4);
            S37.Name = "S37";
            S37.ReadOnly = true;
            S37.Size = new Size(33, 31);
            S37.TabIndex = 54;
            S37.Tag = "";
            S37.TextAlign = HorizontalAlignment.Center;
            // 
            // S35
            // 
            S35.BackColor = SystemColors.Control;
            S35.BorderStyle = BorderStyle.FixedSingle;
            S35.Enabled = false;
            S35.ForeColor = Color.Black;
            S35.Location = new Point(160, 438);
            S35.Margin = new Padding(4);
            S35.Name = "S35";
            S35.ReadOnly = true;
            S35.Size = new Size(33, 31);
            S35.TabIndex = 53;
            S35.Tag = "";
            S35.TextAlign = HorizontalAlignment.Center;
            // 
            // S38
            // 
            S38.BackColor = SystemColors.Control;
            S38.BorderStyle = BorderStyle.FixedSingle;
            S38.Enabled = false;
            S38.ForeColor = Color.Black;
            S38.Location = new Point(160, 245);
            S38.Margin = new Padding(4);
            S38.Name = "S38";
            S38.ReadOnly = true;
            S38.Size = new Size(33, 31);
            S38.TabIndex = 52;
            S38.Tag = "";
            S38.TextAlign = HorizontalAlignment.Center;
            // 
            // S34
            // 
            S34.BackColor = SystemColors.Control;
            S34.BorderStyle = BorderStyle.FixedSingle;
            S34.Enabled = false;
            S34.ForeColor = Color.Black;
            S34.Location = new Point(160, 495);
            S34.Margin = new Padding(4);
            S34.Name = "S34";
            S34.ReadOnly = true;
            S34.Size = new Size(33, 31);
            S34.TabIndex = 51;
            S34.Tag = "";
            S34.TextAlign = HorizontalAlignment.Center;
            // 
            // S39
            // 
            S39.BackColor = SystemColors.Control;
            S39.BorderStyle = BorderStyle.FixedSingle;
            S39.Enabled = false;
            S39.ForeColor = Color.Black;
            S39.Location = new Point(239, 208);
            S39.Margin = new Padding(4);
            S39.Name = "S39";
            S39.ReadOnly = true;
            S39.Size = new Size(33, 31);
            S39.TabIndex = 50;
            S39.Tag = "";
            S39.TextAlign = HorizontalAlignment.Center;
            // 
            // S33
            // 
            S33.BackColor = SystemColors.Control;
            S33.BorderStyle = BorderStyle.FixedSingle;
            S33.Enabled = false;
            S33.ForeColor = Color.Black;
            S33.Location = new Point(239, 530);
            S33.Margin = new Padding(4);
            S33.Name = "S33";
            S33.ReadOnly = true;
            S33.Size = new Size(33, 31);
            S33.TabIndex = 49;
            S33.Tag = "";
            S33.TextAlign = HorizontalAlignment.Center;
            // 
            // S40
            // 
            S40.BackColor = SystemColors.Control;
            S40.BorderStyle = BorderStyle.FixedSingle;
            S40.Enabled = false;
            S40.ForeColor = Color.Black;
            S40.Location = new Point(321, 208);
            S40.Margin = new Padding(4);
            S40.Name = "S40";
            S40.ReadOnly = true;
            S40.Size = new Size(33, 31);
            S40.TabIndex = 48;
            S40.Tag = "";
            S40.TextAlign = HorizontalAlignment.Center;
            // 
            // S32
            // 
            S32.BackColor = SystemColors.Control;
            S32.BorderStyle = BorderStyle.FixedSingle;
            S32.Enabled = false;
            S32.ForeColor = Color.Black;
            S32.Location = new Point(321, 530);
            S32.Margin = new Padding(4);
            S32.Name = "S32";
            S32.ReadOnly = true;
            S32.Size = new Size(33, 31);
            S32.TabIndex = 47;
            S32.Tag = "";
            S32.TextAlign = HorizontalAlignment.Center;
            // 
            // S16
            // 
            S16.BackColor = SystemColors.Control;
            S16.BorderStyle = BorderStyle.FixedSingle;
            S16.Enabled = false;
            S16.ForeColor = Color.Black;
            S16.Location = new Point(1509, 369);
            S16.Margin = new Padding(4);
            S16.Name = "S16";
            S16.ReadOnly = true;
            S16.Size = new Size(33, 31);
            S16.TabIndex = 46;
            S16.Tag = "";
            S16.TextAlign = HorizontalAlignment.Center;
            // 
            // S17
            // 
            S17.BackColor = SystemColors.Control;
            S17.BorderStyle = BorderStyle.FixedSingle;
            S17.Enabled = false;
            S17.ForeColor = Color.Black;
            S17.Location = new Point(1509, 438);
            S17.Margin = new Padding(4);
            S17.Name = "S17";
            S17.ReadOnly = true;
            S17.Size = new Size(33, 31);
            S17.TabIndex = 45;
            S17.Tag = "";
            S17.TextAlign = HorizontalAlignment.Center;
            // 
            // S15
            // 
            S15.BackColor = SystemColors.Control;
            S15.BorderStyle = BorderStyle.FixedSingle;
            S15.Enabled = false;
            S15.ForeColor = Color.Black;
            S15.Location = new Point(1509, 311);
            S15.Margin = new Padding(4);
            S15.Name = "S15";
            S15.ReadOnly = true;
            S15.Size = new Size(33, 31);
            S15.TabIndex = 44;
            S15.Tag = "";
            S15.TextAlign = HorizontalAlignment.Center;
            // 
            // S18
            // 
            S18.BackColor = SystemColors.Control;
            S18.BorderStyle = BorderStyle.FixedSingle;
            S18.Enabled = false;
            S18.ForeColor = Color.Black;
            S18.Location = new Point(1509, 495);
            S18.Margin = new Padding(4);
            S18.Name = "S18";
            S18.ReadOnly = true;
            S18.Size = new Size(33, 31);
            S18.TabIndex = 43;
            S18.Tag = "";
            S18.TextAlign = HorizontalAlignment.Center;
            // 
            // S14
            // 
            S14.BackColor = SystemColors.Control;
            S14.BorderStyle = BorderStyle.FixedSingle;
            S14.Enabled = false;
            S14.ForeColor = Color.Black;
            S14.Location = new Point(1509, 245);
            S14.Margin = new Padding(4);
            S14.Name = "S14";
            S14.ReadOnly = true;
            S14.Size = new Size(33, 31);
            S14.TabIndex = 42;
            S14.Tag = "";
            S14.TextAlign = HorizontalAlignment.Center;
            // 
            // S13
            // 
            S13.BackColor = SystemColors.Control;
            S13.BorderStyle = BorderStyle.FixedSingle;
            S13.Enabled = false;
            S13.ForeColor = Color.Black;
            S13.Location = new Point(1432, 208);
            S13.Margin = new Padding(4);
            S13.Name = "S13";
            S13.ReadOnly = true;
            S13.Size = new Size(33, 31);
            S13.TabIndex = 41;
            S13.Tag = "";
            S13.TextAlign = HorizontalAlignment.Center;
            // 
            // S19
            // 
            S19.BackColor = SystemColors.Control;
            S19.BorderStyle = BorderStyle.FixedSingle;
            S19.Enabled = false;
            S19.ForeColor = Color.Black;
            S19.Location = new Point(1432, 530);
            S19.Margin = new Padding(4);
            S19.Name = "S19";
            S19.ReadOnly = true;
            S19.Size = new Size(33, 31);
            S19.TabIndex = 40;
            S19.Tag = "";
            S19.TextAlign = HorizontalAlignment.Center;
            // 
            // S20
            // 
            S20.BackColor = SystemColors.Control;
            S20.BorderStyle = BorderStyle.FixedSingle;
            S20.Enabled = false;
            S20.ForeColor = Color.Black;
            S20.Location = new Point(1350, 530);
            S20.Margin = new Padding(4);
            S20.Name = "S20";
            S20.ReadOnly = true;
            S20.Size = new Size(33, 31);
            S20.TabIndex = 39;
            S20.Tag = "";
            S20.TextAlign = HorizontalAlignment.Center;
            // 
            // S12
            // 
            S12.BackColor = SystemColors.Control;
            S12.BorderStyle = BorderStyle.FixedSingle;
            S12.Enabled = false;
            S12.ForeColor = Color.Black;
            S12.Location = new Point(1350, 208);
            S12.Margin = new Padding(4);
            S12.Name = "S12";
            S12.ReadOnly = true;
            S12.Size = new Size(33, 31);
            S12.TabIndex = 38;
            S12.Tag = "";
            S12.TextAlign = HorizontalAlignment.Center;
            // 
            // S26
            // 
            S26.BackColor = SystemColors.Control;
            S26.BorderStyle = BorderStyle.FixedSingle;
            S26.Enabled = false;
            S26.ForeColor = Color.Black;
            S26.Location = new Point(851, 618);
            S26.Margin = new Padding(4);
            S26.Name = "S26";
            S26.ReadOnly = true;
            S26.Size = new Size(33, 31);
            S26.TabIndex = 37;
            S26.Tag = "";
            S26.TextAlign = HorizontalAlignment.Center;
            // 
            // S25
            // 
            S25.BackColor = SystemColors.Control;
            S25.BorderStyle = BorderStyle.FixedSingle;
            S25.Enabled = false;
            S25.ForeColor = Color.Black;
            S25.Location = new Point(932, 618);
            S25.Margin = new Padding(4);
            S25.Name = "S25";
            S25.ReadOnly = true;
            S25.Size = new Size(33, 31);
            S25.TabIndex = 36;
            S25.Tag = "";
            S25.TextAlign = HorizontalAlignment.Center;
            // 
            // S27
            // 
            S27.BackColor = SystemColors.Control;
            S27.BorderStyle = BorderStyle.FixedSingle;
            S27.Enabled = false;
            S27.ForeColor = Color.Black;
            S27.Location = new Point(748, 618);
            S27.Margin = new Padding(4);
            S27.Name = "S27";
            S27.ReadOnly = true;
            S27.Size = new Size(33, 31);
            S27.TabIndex = 35;
            S27.Tag = "";
            S27.TextAlign = HorizontalAlignment.Center;
            // 
            // S24
            // 
            S24.BackColor = SystemColors.Control;
            S24.BorderStyle = BorderStyle.FixedSingle;
            S24.Enabled = false;
            S24.ForeColor = Color.Black;
            S24.Location = new Point(1035, 618);
            S24.Margin = new Padding(4);
            S24.Name = "S24";
            S24.ReadOnly = true;
            S24.Size = new Size(33, 31);
            S24.TabIndex = 34;
            S24.Tag = "";
            S24.TextAlign = HorizontalAlignment.Center;
            // 
            // S28
            // 
            S28.BackColor = SystemColors.Control;
            S28.BorderStyle = BorderStyle.FixedSingle;
            S28.Enabled = false;
            S28.ForeColor = Color.Black;
            S28.Location = new Point(650, 618);
            S28.Margin = new Padding(4);
            S28.Name = "S28";
            S28.ReadOnly = true;
            S28.Size = new Size(33, 31);
            S28.TabIndex = 33;
            S28.Tag = "";
            S28.TextAlign = HorizontalAlignment.Center;
            // 
            // S29
            // 
            S29.BackColor = SystemColors.Control;
            S29.BorderStyle = BorderStyle.FixedSingle;
            S29.Enabled = false;
            S29.ForeColor = Color.Black;
            S29.Location = new Point(571, 596);
            S29.Margin = new Padding(4);
            S29.Name = "S29";
            S29.ReadOnly = true;
            S29.Size = new Size(33, 31);
            S29.TabIndex = 32;
            S29.Tag = "";
            S29.TextAlign = HorizontalAlignment.Center;
            // 
            // S23
            // 
            S23.BackColor = SystemColors.Control;
            S23.BorderStyle = BorderStyle.FixedSingle;
            S23.Enabled = false;
            S23.ForeColor = Color.Black;
            S23.Location = new Point(1101, 596);
            S23.Margin = new Padding(4);
            S23.Name = "S23";
            S23.ReadOnly = true;
            S23.Size = new Size(33, 31);
            S23.TabIndex = 31;
            S23.Tag = "";
            S23.TextAlign = HorizontalAlignment.Center;
            // 
            // S22
            // 
            S22.BackColor = SystemColors.Control;
            S22.BorderStyle = BorderStyle.FixedSingle;
            S22.Enabled = false;
            S22.ForeColor = Color.Black;
            S22.Location = new Point(1186, 579);
            S22.Margin = new Padding(4);
            S22.Name = "S22";
            S22.ReadOnly = true;
            S22.Size = new Size(33, 31);
            S22.TabIndex = 30;
            S22.Tag = "";
            S22.TextAlign = HorizontalAlignment.Center;
            // 
            // S30
            // 
            S30.BackColor = SystemColors.Control;
            S30.BorderStyle = BorderStyle.FixedSingle;
            S30.Enabled = false;
            S30.ForeColor = Color.Black;
            S30.Location = new Point(499, 579);
            S30.Margin = new Padding(4);
            S30.Name = "S30";
            S30.ReadOnly = true;
            S30.Size = new Size(33, 31);
            S30.TabIndex = 29;
            S30.Tag = "";
            S30.TextAlign = HorizontalAlignment.Center;
            // 
            // S21
            // 
            S21.BackColor = SystemColors.Control;
            S21.BorderStyle = BorderStyle.FixedSingle;
            S21.Enabled = false;
            S21.ForeColor = Color.White;
            S21.Location = new Point(1274, 566);
            S21.Margin = new Padding(4);
            S21.Name = "S21";
            S21.ReadOnly = true;
            S21.Size = new Size(33, 31);
            S21.TabIndex = 28;
            S21.Tag = "";
            S21.Text = "S";
            S21.TextAlign = HorizontalAlignment.Center;
            // 
            // S31
            // 
            S31.BackColor = SystemColors.Control;
            S31.BorderStyle = BorderStyle.FixedSingle;
            S31.Enabled = false;
            S31.ForeColor = Color.White;
            S31.Location = new Point(412, 566);
            S31.Margin = new Padding(4);
            S31.Name = "S31";
            S31.ReadOnly = true;
            S31.Size = new Size(33, 31);
            S31.TabIndex = 27;
            S31.Tag = "";
            S31.Text = "S";
            S31.TextAlign = HorizontalAlignment.Center;
            // 
            // S6
            // 
            S6.BackColor = SystemColors.Control;
            S6.BorderStyle = BorderStyle.FixedSingle;
            S6.Enabled = false;
            S6.ForeColor = Color.Black;
            S6.Location = new Point(851, 102);
            S6.Margin = new Padding(4);
            S6.Name = "S6";
            S6.ReadOnly = true;
            S6.Size = new Size(33, 31);
            S6.TabIndex = 26;
            S6.Tag = "";
            S6.TextAlign = HorizontalAlignment.Center;
            // 
            // S7
            // 
            S7.BackColor = SystemColors.Control;
            S7.BorderStyle = BorderStyle.FixedSingle;
            S7.Enabled = false;
            S7.ForeColor = Color.Black;
            S7.Location = new Point(932, 102);
            S7.Margin = new Padding(4);
            S7.Name = "S7";
            S7.ReadOnly = true;
            S7.Size = new Size(33, 31);
            S7.TabIndex = 25;
            S7.Tag = "";
            S7.TextAlign = HorizontalAlignment.Center;
            // 
            // S5
            // 
            S5.BackColor = SystemColors.Control;
            S5.BorderStyle = BorderStyle.FixedSingle;
            S5.Enabled = false;
            S5.ForeColor = Color.Black;
            S5.Location = new Point(748, 102);
            S5.Margin = new Padding(4);
            S5.Name = "S5";
            S5.ReadOnly = true;
            S5.Size = new Size(33, 31);
            S5.TabIndex = 24;
            S5.Tag = "";
            S5.TextAlign = HorizontalAlignment.Center;
            // 
            // S8
            // 
            S8.BackColor = SystemColors.Control;
            S8.BorderStyle = BorderStyle.FixedSingle;
            S8.Enabled = false;
            S8.ForeColor = Color.Black;
            S8.Location = new Point(1035, 102);
            S8.Margin = new Padding(4);
            S8.Name = "S8";
            S8.ReadOnly = true;
            S8.Size = new Size(33, 31);
            S8.TabIndex = 23;
            S8.Tag = "";
            S8.TextAlign = HorizontalAlignment.Center;
            // 
            // S4
            // 
            S4.BackColor = SystemColors.Control;
            S4.BorderStyle = BorderStyle.FixedSingle;
            S4.Enabled = false;
            S4.ForeColor = Color.Black;
            S4.Location = new Point(650, 102);
            S4.Margin = new Padding(4);
            S4.Name = "S4";
            S4.ReadOnly = true;
            S4.Size = new Size(33, 31);
            S4.TabIndex = 22;
            S4.Tag = "";
            S4.TextAlign = HorizontalAlignment.Center;
            // 
            // S3
            // 
            S3.BackColor = SystemColors.Control;
            S3.BorderStyle = BorderStyle.FixedSingle;
            S3.Enabled = false;
            S3.ForeColor = Color.Black;
            S3.Location = new Point(571, 118);
            S3.Margin = new Padding(4);
            S3.Name = "S3";
            S3.ReadOnly = true;
            S3.Size = new Size(33, 31);
            S3.TabIndex = 21;
            S3.Tag = "";
            S3.TextAlign = HorizontalAlignment.Center;
            // 
            // S9
            // 
            S9.BackColor = SystemColors.Control;
            S9.BorderStyle = BorderStyle.FixedSingle;
            S9.Enabled = false;
            S9.ForeColor = Color.Black;
            S9.Location = new Point(1101, 118);
            S9.Margin = new Padding(4);
            S9.Name = "S9";
            S9.ReadOnly = true;
            S9.Size = new Size(33, 31);
            S9.TabIndex = 20;
            S9.Tag = "";
            S9.TextAlign = HorizontalAlignment.Center;
            // 
            // S10
            // 
            S10.BackColor = SystemColors.Control;
            S10.BorderStyle = BorderStyle.FixedSingle;
            S10.Enabled = false;
            S10.ForeColor = Color.Black;
            S10.Location = new Point(1186, 139);
            S10.Margin = new Padding(4);
            S10.Name = "S10";
            S10.ReadOnly = true;
            S10.Size = new Size(33, 31);
            S10.TabIndex = 19;
            S10.Tag = "";
            S10.TextAlign = HorizontalAlignment.Center;
            // 
            // S2
            // 
            S2.BackColor = SystemColors.Control;
            S2.BorderStyle = BorderStyle.FixedSingle;
            S2.Enabled = false;
            S2.ForeColor = Color.Black;
            S2.Location = new Point(499, 139);
            S2.Margin = new Padding(4);
            S2.Name = "S2";
            S2.ReadOnly = true;
            S2.Size = new Size(33, 31);
            S2.TabIndex = 18;
            S2.Tag = "";
            S2.TextAlign = HorizontalAlignment.Center;
            // 
            // S11
            // 
            S11.BackColor = SystemColors.Control;
            S11.BorderStyle = BorderStyle.FixedSingle;
            S11.Enabled = false;
            S11.ForeColor = Color.White;
            S11.Location = new Point(1274, 164);
            S11.Margin = new Padding(4);
            S11.Name = "S11";
            S11.ReadOnly = true;
            S11.Size = new Size(33, 31);
            S11.TabIndex = 17;
            S11.Tag = "";
            S11.Text = "S";
            S11.TextAlign = HorizontalAlignment.Center;
            // 
            // S1
            // 
            S1.BackColor = SystemColors.Control;
            S1.BorderStyle = BorderStyle.FixedSingle;
            S1.Enabled = false;
            S1.ForeColor = Color.White;
            S1.Location = new Point(412, 164);
            S1.Margin = new Padding(4);
            S1.Name = "S1";
            S1.ReadOnly = true;
            S1.Size = new Size(33, 31);
            S1.TabIndex = 16;
            S1.Tag = "";
            S1.Text = "S";
            S1.TextAlign = HorizontalAlignment.Center;
            // 
            // BC3
            // 
            BC3.BackColor = Color.Blue;
            BC3.BorderStyle = BorderStyle.FixedSingle;
            BC3.Enabled = false;
            BC3.ForeColor = Color.White;
            BC3.Location = new Point(1481, 682);
            BC3.Margin = new Padding(4);
            BC3.Name = "BC3";
            BC3.ReadOnly = true;
            BC3.Size = new Size(33, 31);
            BC3.TabIndex = 15;
            BC3.Tag = "";
            BC3.Text = "C";
            BC3.TextAlign = HorizontalAlignment.Center;
            // 
            // BC4
            // 
            BC4.BackColor = Color.Blue;
            BC4.BorderStyle = BorderStyle.FixedSingle;
            BC4.Enabled = false;
            BC4.ForeColor = Color.White;
            BC4.Location = new Point(1416, 682);
            BC4.Margin = new Padding(4);
            BC4.Name = "BC4";
            BC4.ReadOnly = true;
            BC4.Size = new Size(33, 31);
            BC4.TabIndex = 14;
            BC4.Tag = "";
            BC4.Text = "C";
            BC4.TextAlign = HorizontalAlignment.Center;
            // 
            // BC2
            // 
            BC2.BackColor = Color.Blue;
            BC2.BorderStyle = BorderStyle.FixedSingle;
            BC2.Enabled = false;
            BC2.ForeColor = Color.White;
            BC2.Location = new Point(1481, 624);
            BC2.Margin = new Padding(4);
            BC2.Name = "BC2";
            BC2.ReadOnly = true;
            BC2.Size = new Size(33, 31);
            BC2.TabIndex = 13;
            BC2.Tag = "";
            BC2.Text = "C";
            BC2.TextAlign = HorizontalAlignment.Center;
            // 
            // BC1
            // 
            BC1.AcceptsReturn = true;
            BC1.BackColor = Color.Blue;
            BC1.BorderStyle = BorderStyle.FixedSingle;
            BC1.Enabled = false;
            BC1.ForeColor = Color.White;
            BC1.Location = new Point(1416, 624);
            BC1.Margin = new Padding(4);
            BC1.Name = "BC1";
            BC1.ReadOnly = true;
            BC1.Size = new Size(33, 31);
            BC1.TabIndex = 12;
            BC1.Tag = "";
            BC1.Text = "C";
            BC1.TextAlign = HorizontalAlignment.Center;
            // 
            // GC3
            // 
            GC3.BackColor = Color.Green;
            GC3.BorderStyle = BorderStyle.FixedSingle;
            GC3.Enabled = false;
            GC3.ForeColor = Color.White;
            GC3.Location = new Point(272, 682);
            GC3.Margin = new Padding(4);
            GC3.Name = "GC3";
            GC3.ReadOnly = true;
            GC3.Size = new Size(33, 31);
            GC3.TabIndex = 11;
            GC3.Tag = "";
            GC3.Text = "C";
            GC3.TextAlign = HorizontalAlignment.Center;
            // 
            // GC4
            // 
            GC4.BackColor = Color.Green;
            GC4.BorderStyle = BorderStyle.FixedSingle;
            GC4.Enabled = false;
            GC4.ForeColor = Color.White;
            GC4.Location = new Point(208, 682);
            GC4.Margin = new Padding(4);
            GC4.Name = "GC4";
            GC4.ReadOnly = true;
            GC4.Size = new Size(33, 31);
            GC4.TabIndex = 10;
            GC4.Tag = "";
            GC4.Text = "C";
            GC4.TextAlign = HorizontalAlignment.Center;
            // 
            // GC2
            // 
            GC2.BackColor = Color.Green;
            GC2.BorderStyle = BorderStyle.FixedSingle;
            GC2.Enabled = false;
            GC2.ForeColor = Color.White;
            GC2.Location = new Point(272, 624);
            GC2.Margin = new Padding(4);
            GC2.Name = "GC2";
            GC2.ReadOnly = true;
            GC2.Size = new Size(33, 31);
            GC2.TabIndex = 9;
            GC2.Tag = "";
            GC2.Text = "C";
            GC2.TextAlign = HorizontalAlignment.Center;
            // 
            // GC1
            // 
            GC1.BackColor = Color.Green;
            GC1.BorderStyle = BorderStyle.FixedSingle;
            GC1.Enabled = false;
            GC1.ForeColor = Color.White;
            GC1.Location = new Point(208, 624);
            GC1.Margin = new Padding(4);
            GC1.Name = "GC1";
            GC1.ReadOnly = true;
            GC1.Size = new Size(33, 31);
            GC1.TabIndex = 8;
            GC1.Tag = "";
            GC1.Text = "C";
            GC1.TextAlign = HorizontalAlignment.Center;
            // 
            // RC3
            // 
            RC3.BackColor = Color.Red;
            RC3.BorderStyle = BorderStyle.FixedSingle;
            RC3.Enabled = false;
            RC3.ForeColor = Color.White;
            RC3.Location = new Point(1481, 118);
            RC3.Margin = new Padding(4);
            RC3.Name = "RC3";
            RC3.ReadOnly = true;
            RC3.Size = new Size(33, 31);
            RC3.TabIndex = 7;
            RC3.Tag = "";
            RC3.Text = "C";
            RC3.TextAlign = HorizontalAlignment.Center;
            // 
            // RC4
            // 
            RC4.BackColor = Color.Red;
            RC4.BorderStyle = BorderStyle.FixedSingle;
            RC4.Enabled = false;
            RC4.ForeColor = Color.White;
            RC4.Location = new Point(1416, 118);
            RC4.Margin = new Padding(4);
            RC4.Name = "RC4";
            RC4.ReadOnly = true;
            RC4.Size = new Size(33, 31);
            RC4.TabIndex = 6;
            RC4.Tag = "";
            RC4.Text = "C";
            RC4.TextAlign = HorizontalAlignment.Center;
            // 
            // RC2
            // 
            RC2.BackColor = Color.Red;
            RC2.BorderStyle = BorderStyle.FixedSingle;
            RC2.Enabled = false;
            RC2.ForeColor = Color.White;
            RC2.Location = new Point(1481, 59);
            RC2.Margin = new Padding(4);
            RC2.Name = "RC2";
            RC2.ReadOnly = true;
            RC2.Size = new Size(33, 31);
            RC2.TabIndex = 5;
            RC2.Tag = "";
            RC2.Text = "C";
            RC2.TextAlign = HorizontalAlignment.Center;
            // 
            // RC1
            // 
            RC1.BackColor = Color.Red;
            RC1.BorderStyle = BorderStyle.FixedSingle;
            RC1.Enabled = false;
            RC1.ForeColor = Color.White;
            RC1.Location = new Point(1416, 59);
            RC1.Margin = new Padding(4);
            RC1.Name = "RC1";
            RC1.ReadOnly = true;
            RC1.Size = new Size(33, 31);
            RC1.TabIndex = 4;
            RC1.Tag = "";
            RC1.Text = "C";
            RC1.TextAlign = HorizontalAlignment.Center;
            // 
            // YC4
            // 
            YC4.BackColor = Color.Yellow;
            YC4.BorderStyle = BorderStyle.FixedSingle;
            YC4.Enabled = false;
            YC4.ForeColor = Color.White;
            YC4.Location = new Point(272, 118);
            YC4.Margin = new Padding(4);
            YC4.Name = "YC4";
            YC4.ReadOnly = true;
            YC4.Size = new Size(33, 31);
            YC4.TabIndex = 3;
            YC4.Tag = "";
            YC4.Text = "C";
            YC4.TextAlign = HorizontalAlignment.Center;
            // 
            // YC3
            // 
            YC3.BackColor = Color.Yellow;
            YC3.BorderStyle = BorderStyle.FixedSingle;
            YC3.Enabled = false;
            YC3.ForeColor = Color.White;
            YC3.Location = new Point(208, 118);
            YC3.Margin = new Padding(4);
            YC3.Name = "YC3";
            YC3.ReadOnly = true;
            YC3.Size = new Size(33, 31);
            YC3.TabIndex = 2;
            YC3.Tag = "";
            YC3.Text = "C";
            YC3.TextAlign = HorizontalAlignment.Center;
            // 
            // YC2
            // 
            YC2.BackColor = Color.Yellow;
            YC2.BorderStyle = BorderStyle.FixedSingle;
            YC2.Enabled = false;
            YC2.ForeColor = Color.White;
            YC2.Location = new Point(272, 59);
            YC2.Margin = new Padding(4);
            YC2.Name = "YC2";
            YC2.ReadOnly = true;
            YC2.Size = new Size(33, 31);
            YC2.TabIndex = 1;
            YC2.Tag = "";
            YC2.Text = "C";
            YC2.TextAlign = HorizontalAlignment.Center;
            // 
            // YC1
            // 
            YC1.BackColor = Color.Yellow;
            YC1.BorderStyle = BorderStyle.FixedSingle;
            YC1.Enabled = false;
            YC1.ForeColor = Color.White;
            YC1.Location = new Point(208, 59);
            YC1.Margin = new Padding(4);
            YC1.Name = "YC1";
            YC1.ReadOnly = true;
            YC1.Size = new Size(33, 31);
            YC1.TabIndex = 0;
            YC1.Tag = "";
            YC1.Text = "C";
            YC1.TextAlign = HorizontalAlignment.Center;
            // 
            // GameConfigPanel
            // 
            GameConfigPanel.BorderStyle = BorderStyle.FixedSingle;
            GameConfigPanel.Controls.Add(SettingPlayer4);
            GameConfigPanel.Controls.Add(SettingPlayer3);
            GameConfigPanel.Controls.Add(SettingPlayer2);
            GameConfigPanel.Controls.Add(SettingPlayer1);
            GameConfigPanel.Controls.Add(GameStrategyLabel);
            GameConfigPanel.Controls.Add(NumberOfMatchesSelector);
            GameConfigPanel.Controls.Add(NumberOfMatchesLabel);
            GameConfigPanel.Controls.Add(NumberOfPlayersSelector);
            GameConfigPanel.Controls.Add(NumberOfPlayersLabel);
            GameConfigPanel.Controls.Add(StartGAmeButton);
            GameConfigPanel.Controls.Add(GameConfigLabel);
            GameConfigPanel.Dock = DockStyle.Right;
            GameConfigPanel.Location = new Point(1552, 0);
            GameConfigPanel.Margin = new Padding(4);
            GameConfigPanel.Name = "GameConfigPanel";
            GameConfigPanel.Size = new Size(348, 744);
            GameConfigPanel.TabIndex = 0;
            // 
            // SettingPlayer4
            // 
            SettingPlayer4.Dock = DockStyle.Top;
            SettingPlayer4.FlatStyle = FlatStyle.Flat;
            SettingPlayer4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SettingPlayer4.ForeColor = Color.Green;
            SettingPlayer4.Location = new Point(0, 504);
            SettingPlayer4.Name = "SettingPlayer4";
            SettingPlayer4.Size = new Size(346, 52);
            SettingPlayer4.TabIndex = 10;
            SettingPlayer4.Text = "SetStrategyForPlayer1";
            SettingPlayer4.UseVisualStyleBackColor = true;
            SettingPlayer4.Click += SettingPlayer4_Click;
            // 
            // SettingPlayer3
            // 
            SettingPlayer3.Dock = DockStyle.Top;
            SettingPlayer3.FlatStyle = FlatStyle.Flat;
            SettingPlayer3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SettingPlayer3.ForeColor = Color.Blue;
            SettingPlayer3.Location = new Point(0, 452);
            SettingPlayer3.Name = "SettingPlayer3";
            SettingPlayer3.Size = new Size(346, 52);
            SettingPlayer3.TabIndex = 9;
            SettingPlayer3.Text = "SetStrategyForPlayer1";
            SettingPlayer3.UseVisualStyleBackColor = true;
            SettingPlayer3.Click += SettingPlayer3_Click;
            // 
            // SettingPlayer2
            // 
            SettingPlayer2.Dock = DockStyle.Top;
            SettingPlayer2.FlatStyle = FlatStyle.Flat;
            SettingPlayer2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SettingPlayer2.ForeColor = Color.Red;
            SettingPlayer2.Location = new Point(0, 400);
            SettingPlayer2.Name = "SettingPlayer2";
            SettingPlayer2.Size = new Size(346, 52);
            SettingPlayer2.TabIndex = 8;
            SettingPlayer2.Text = "SetStrategyForPlayer1";
            SettingPlayer2.UseVisualStyleBackColor = true;
            SettingPlayer2.Click += SettingPlayer2_Click;
            // 
            // SettingPlayer1
            // 
            SettingPlayer1.Dock = DockStyle.Top;
            SettingPlayer1.FlatStyle = FlatStyle.Flat;
            SettingPlayer1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SettingPlayer1.ForeColor = Color.Yellow;
            SettingPlayer1.Location = new Point(0, 348);
            SettingPlayer1.Name = "SettingPlayer1";
            SettingPlayer1.Size = new Size(346, 52);
            SettingPlayer1.TabIndex = 7;
            SettingPlayer1.Text = "SetStrategyForPlayer1";
            SettingPlayer1.UseVisualStyleBackColor = true;
            SettingPlayer1.Click += SettingPlayer1_Click;
            // 
            // GameStrategyLabel
            // 
            GameStrategyLabel.AutoSize = true;
            GameStrategyLabel.Dock = DockStyle.Top;
            GameStrategyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            GameStrategyLabel.Location = new Point(0, 268);
            GameStrategyLabel.Margin = new Padding(2, 0, 2, 0);
            GameStrategyLabel.Name = "GameStrategyLabel";
            GameStrategyLabel.Padding = new Padding(25, 38, 0, 10);
            GameStrategyLabel.Size = new Size(193, 80);
            GameStrategyLabel.TabIndex = 6;
            GameStrategyLabel.Text = "GameStrategy:";
            // 
            // NumberOfMatchesSelector
            // 
            NumberOfMatchesSelector.BorderStyle = BorderStyle.FixedSingle;
            NumberOfMatchesSelector.Dock = DockStyle.Top;
            NumberOfMatchesSelector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumberOfMatchesSelector.Location = new Point(0, 229);
            NumberOfMatchesSelector.Margin = new Padding(2);
            NumberOfMatchesSelector.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            NumberOfMatchesSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfMatchesSelector.Name = "NumberOfMatchesSelector";
            NumberOfMatchesSelector.Size = new Size(346, 39);
            NumberOfMatchesSelector.TabIndex = 5;
            NumberOfMatchesSelector.TextAlign = HorizontalAlignment.Center;
            NumberOfMatchesSelector.ThousandsSeparator = true;
            NumberOfMatchesSelector.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // NumberOfMatchesLabel
            // 
            NumberOfMatchesLabel.AutoSize = true;
            NumberOfMatchesLabel.Dock = DockStyle.Top;
            NumberOfMatchesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumberOfMatchesLabel.Location = new Point(0, 153);
            NumberOfMatchesLabel.Margin = new Padding(2, 0, 2, 0);
            NumberOfMatchesLabel.Name = "NumberOfMatchesLabel";
            NumberOfMatchesLabel.Padding = new Padding(25, 38, 0, 6);
            NumberOfMatchesLabel.Size = new Size(248, 76);
            NumberOfMatchesLabel.TabIndex = 4;
            NumberOfMatchesLabel.Text = "NumberOfMatches:";
            // 
            // NumberOfPlayersSelector
            // 
            NumberOfPlayersSelector.BorderStyle = BorderStyle.FixedSingle;
            NumberOfPlayersSelector.Dock = DockStyle.Top;
            NumberOfPlayersSelector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumberOfPlayersSelector.Location = new Point(0, 114);
            NumberOfPlayersSelector.Margin = new Padding(2);
            NumberOfPlayersSelector.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            NumberOfPlayersSelector.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NumberOfPlayersSelector.Name = "NumberOfPlayersSelector";
            NumberOfPlayersSelector.Size = new Size(346, 39);
            NumberOfPlayersSelector.TabIndex = 3;
            NumberOfPlayersSelector.TextAlign = HorizontalAlignment.Center;
            NumberOfPlayersSelector.Value = new decimal(new int[] { 4, 0, 0, 0 });
            NumberOfPlayersSelector.ValueChanged += NumberOfPlayersSelector_ValueChanged;
            // 
            // NumberOfPlayersLabel
            // 
            NumberOfPlayersLabel.AutoSize = true;
            NumberOfPlayersLabel.Dock = DockStyle.Top;
            NumberOfPlayersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NumberOfPlayersLabel.Location = new Point(0, 76);
            NumberOfPlayersLabel.Margin = new Padding(2, 0, 2, 0);
            NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            NumberOfPlayersLabel.Padding = new Padding(25, 0, 0, 6);
            NumberOfPlayersLabel.Size = new Size(232, 38);
            NumberOfPlayersLabel.TabIndex = 2;
            NumberOfPlayersLabel.Text = "NumberOfPlayers:";
            // 
            // StartGAmeButton
            // 
            StartGAmeButton.Dock = DockStyle.Bottom;
            StartGAmeButton.FlatStyle = FlatStyle.Flat;
            StartGAmeButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 238);
            StartGAmeButton.Location = new Point(0, 662);
            StartGAmeButton.Margin = new Padding(2);
            StartGAmeButton.Name = "StartGAmeButton";
            StartGAmeButton.Size = new Size(346, 80);
            StartGAmeButton.TabIndex = 1;
            StartGAmeButton.Text = "StartGame";
            StartGAmeButton.UseVisualStyleBackColor = true;
            StartGAmeButton.Click += StartGAmeButton_Click;
            // 
            // GameConfigLabel
            // 
            GameConfigLabel.AutoSize = true;
            GameConfigLabel.Dock = DockStyle.Top;
            GameConfigLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            GameConfigLabel.Location = new Point(0, 0);
            GameConfigLabel.Margin = new Padding(4, 0, 4, 0);
            GameConfigLabel.Name = "GameConfigLabel";
            GameConfigLabel.Padding = new Padding(91, 0, 91, 44);
            GameConfigLabel.Size = new Size(337, 76);
            GameConfigLabel.TabIndex = 0;
            GameConfigLabel.Text = "GameConfig";
            GameConfigLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BearGameProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 785);
            Controls.Add(GameView);
            Controls.Add(ViewControlPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "BearGameProject";
            Text = "BearGameProject";
            WindowState = FormWindowState.Maximized;
            ViewControlPanel.ResumeLayout(false);
            GameView.ResumeLayout(false);
            GameTablePanel.ResumeLayout(false);
            GameTablePanel.PerformLayout();
            GameConfigPanel.ResumeLayout(false);
            GameConfigPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberOfMatchesSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPlayersSelector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ViewControlPanel;
        private Button GameViewButton;
        private Button StatisticsViewButton;
        private Panel GameView;
        private Panel GameTablePanel;
        private Panel GameConfigPanel;
        private Label GameConfigLabel;
        private TextBox YC1;
        private TextBox YC4;
        private TextBox YC3;
        private TextBox YC2;
        private TextBox RC3;
        private TextBox RC4;
        private TextBox RC2;
        private TextBox RC1;
        private TextBox GC3;
        private TextBox GC4;
        private TextBox GC2;
        private TextBox GC1;
        private TextBox BC3;
        private TextBox BC4;
        private TextBox BC2;
        private TextBox BC1;
        private TextBox S1;
        private TextBox S11;
        private TextBox S6;
        private TextBox S7;
        private TextBox S5;
        private TextBox S8;
        private TextBox S4;
        private TextBox S3;
        private TextBox S9;
        private TextBox S10;
        private TextBox S2;
        private TextBox S26;
        private TextBox S25;
        private TextBox S27;
        private TextBox S24;
        private TextBox S28;
        private TextBox S29;
        private TextBox S23;
        private TextBox S22;
        private TextBox S30;
        private TextBox S21;
        private TextBox S31;
        private TextBox S13;
        private TextBox S19;
        private TextBox S20;
        private TextBox S12;
        private TextBox S33;
        private TextBox S40;
        private TextBox S32;
        private TextBox S16;
        private TextBox S17;
        private TextBox S15;
        private TextBox S18;
        private TextBox S14;
        private TextBox S36;
        private TextBox S37;
        private TextBox S35;
        private TextBox S38;
        private TextBox S34;
        private TextBox S39;
        private TextBox YF4;
        private TextBox YF3;
        private TextBox YF2;
        private TextBox YF1;
        private TextBox BF1;
        private TextBox RF4;
        private TextBox RF3;
        private TextBox RF2;
        private TextBox RF1;
        private TextBox GF4;
        private TextBox GF3;
        private TextBox GF2;
        private TextBox GF1;
        private TextBox BF4;
        private TextBox BF3;
        private TextBox BF2;
        private Button StartGAmeButton;
        private NumericUpDown NumberOfPlayersSelector;
        private Label NumberOfPlayersLabel;
        private NumericUpDown NumberOfMatchesSelector;
        private Label NumberOfMatchesLabel;
        private Label GameStrategyLabel;
        private Button SettingPlayer1;
        private Button SettingPlayer4;
        private Button SettingPlayer3;
        private Button SettingPlayer2;
    }
}
