﻿namespace ADGP125
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatePlayer = new System.Windows.Forms.Button();
            this.numberOfplayer = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.PlayerNumber = new System.Windows.Forms.ComboBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player1Selection = new System.Windows.Forms.ComboBox();
            this.Player2Selection = new System.Windows.Forms.ComboBox();
            this.Player3Selection = new System.Windows.Forms.ComboBox();
            this.Player4Selection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.Location = new System.Drawing.Point(97, 84);
            this.CreatePlayer.Name = "CreatePlayer";
            this.CreatePlayer.Size = new System.Drawing.Size(87, 28);
            this.CreatePlayer.TabIndex = 0;
            this.CreatePlayer.Text = "Create Player";
            this.CreatePlayer.UseVisualStyleBackColor = true;
            this.CreatePlayer.Click += new System.EventHandler(this.CreatePlayer_Click);
            // 
            // numberOfplayer
            // 
            this.numberOfplayer.AutoSize = true;
            this.numberOfplayer.Location = new System.Drawing.Point(94, 36);
            this.numberOfplayer.Name = "numberOfplayer";
            this.numberOfplayer.Size = new System.Drawing.Size(88, 13);
            this.numberOfplayer.TabIndex = 2;
            this.numberOfplayer.Text = "Number of Player";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(95, 345);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(87, 31);
            this.Play.TabIndex = 4;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.FormattingEnabled = true;
            this.PlayerNumber.Items.AddRange(new object[] {
            "2 ",
            "3 ",
            "4 "});
            this.PlayerNumber.Location = new System.Drawing.Point(77, 52);
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.Size = new System.Drawing.Size(123, 21);
            this.PlayerNumber.TabIndex = 5;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(35, 123);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(42, 13);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Player1";
            this.Player1.Visible = false;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(35, 174);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(42, 13);
            this.Player2.TabIndex = 7;
            this.Player2.Text = "Player2";
            this.Player2.Visible = false;
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(35, 227);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(42, 13);
            this.Player3.TabIndex = 8;
            this.Player3.Text = "Player3";
            this.Player3.Visible = false;
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(35, 281);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(42, 13);
            this.Player4.TabIndex = 9;
            this.Player4.Text = "Player4";
            this.Player4.Visible = false;
            // 
            // Player1Selection
            // 
            this.Player1Selection.FormattingEnabled = true;
            this.Player1Selection.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Healer",
            "Archer"});
            this.Player1Selection.Location = new System.Drawing.Point(38, 140);
            this.Player1Selection.Name = "Player1Selection";
            this.Player1Selection.Size = new System.Drawing.Size(121, 21);
            this.Player1Selection.TabIndex = 10;
            this.Player1Selection.Visible = false;
            // 
            // Player2Selection
            // 
            this.Player2Selection.FormattingEnabled = true;
            this.Player2Selection.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Healer",
            "Archer"});
            this.Player2Selection.Location = new System.Drawing.Point(38, 191);
            this.Player2Selection.Name = "Player2Selection";
            this.Player2Selection.Size = new System.Drawing.Size(121, 21);
            this.Player2Selection.TabIndex = 11;
            this.Player2Selection.Visible = false;
            // 
            // Player3Selection
            // 
            this.Player3Selection.FormattingEnabled = true;
            this.Player3Selection.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Healer",
            "Archer"});
            this.Player3Selection.Location = new System.Drawing.Point(38, 244);
            this.Player3Selection.Name = "Player3Selection";
            this.Player3Selection.Size = new System.Drawing.Size(121, 21);
            this.Player3Selection.TabIndex = 12;
            this.Player3Selection.Visible = false;
            // 
            // Player4Selection
            // 
            this.Player4Selection.FormattingEnabled = true;
            this.Player4Selection.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Healer",
            "Archer"});
            this.Player4Selection.Location = new System.Drawing.Point(38, 298);
            this.Player4Selection.Name = "Player4Selection";
            this.Player4Selection.Size = new System.Drawing.Size(121, 21);
            this.Player4Selection.TabIndex = 13;
            this.Player4Selection.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 399);
            this.Controls.Add(this.Player4Selection);
            this.Controls.Add(this.Player3Selection);
            this.Controls.Add(this.Player2Selection);
            this.Controls.Add(this.Player1Selection);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.PlayerNumber);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.numberOfplayer);
            this.Controls.Add(this.CreatePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePlayer;
        private System.Windows.Forms.Label numberOfplayer;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.ComboBox PlayerNumber;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.ComboBox Player1Selection;
        private System.Windows.Forms.ComboBox Player2Selection;
        private System.Windows.Forms.ComboBox Player3Selection;
        private System.Windows.Forms.ComboBox Player4Selection;
    }
}

