namespace ADGP125
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.Location = new System.Drawing.Point(131, 180);
            this.CreatePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreatePlayer.Name = "CreatePlayer";
            this.CreatePlayer.Size = new System.Drawing.Size(116, 34);
            this.CreatePlayer.TabIndex = 0;
            this.CreatePlayer.Text = "Create Player";
            this.CreatePlayer.UseVisualStyleBackColor = true;
            this.CreatePlayer.Click += new System.EventHandler(this.CreatePlayer_Click);
            // 
            // numberOfplayer
            // 
            this.numberOfplayer.AutoSize = true;
            this.numberOfplayer.Location = new System.Drawing.Point(127, 121);
            this.numberOfplayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfplayer.Name = "numberOfplayer";
            this.numberOfplayer.Size = new System.Drawing.Size(118, 17);
            this.numberOfplayer.TabIndex = 2;
            this.numberOfplayer.Text = "Number of Player";
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(129, 513);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(116, 38);
            this.Play.TabIndex = 4;
            this.Play.Text = "Submit";
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
            this.PlayerNumber.Location = new System.Drawing.Point(105, 141);
            this.PlayerNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.Size = new System.Drawing.Size(163, 24);
            this.PlayerNumber.TabIndex = 5;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(47, 233);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(56, 17);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Player1";
            this.Player1.Visible = false;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(47, 296);
            this.Player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(56, 17);
            this.Player2.TabIndex = 7;
            this.Player2.Text = "Player2";
            this.Player2.Visible = false;
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(47, 361);
            this.Player3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(56, 17);
            this.Player3.TabIndex = 8;
            this.Player3.Text = "Player3";
            this.Player3.Visible = false;
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(47, 428);
            this.Player4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(56, 17);
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
            this.Player1Selection.Location = new System.Drawing.Point(51, 254);
            this.Player1Selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player1Selection.Name = "Player1Selection";
            this.Player1Selection.Size = new System.Drawing.Size(160, 24);
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
            this.Player2Selection.Location = new System.Drawing.Point(51, 317);
            this.Player2Selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player2Selection.Name = "Player2Selection";
            this.Player2Selection.Size = new System.Drawing.Size(160, 24);
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
            this.Player3Selection.Location = new System.Drawing.Point(51, 382);
            this.Player3Selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player3Selection.Name = "Player3Selection";
            this.Player3Selection.Size = new System.Drawing.Size(160, 24);
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
            this.Player4Selection.Location = new System.Drawing.Point(51, 449);
            this.Player4Selection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player4Selection.Name = "Player4Selection";
            this.Player4Selection.Size = new System.Drawing.Size(160, 24);
            this.Player4Selection.TabIndex = 13;
            this.Player4Selection.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(605, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 394);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(853, -1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 394);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1101, -1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(227, 394);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "UserName";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(105, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 26);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 686);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player4Selection);
            this.Controls.Add(this.Player3Selection);
            this.Controls.Add(this.Player2Selection);
            this.Controls.Add(this.Player1Selection);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.PlayerNumber);
            this.Controls.Add(this.numberOfplayer);
            this.Controls.Add(this.CreatePlayer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

