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
            this.Submit = new System.Windows.Forms.Button();
            this.PlayerNumber = new System.Windows.Forms.ComboBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player1Selection = new System.Windows.Forms.ComboBox();
            this.Player2Selection = new System.Windows.Forms.ComboBox();
            this.Player3Selection = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.RichTextBox();
            this.Mage = new System.Windows.Forms.Label();
            this.Warrior = new System.Windows.Forms.Label();
            this.Healer = new System.Windows.Forms.Label();
            this.Archer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.Location = new System.Drawing.Point(98, 146);
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
            this.numberOfplayer.Location = new System.Drawing.Point(95, 98);
            this.numberOfplayer.Name = "numberOfplayer";
            this.numberOfplayer.Size = new System.Drawing.Size(88, 13);
            this.numberOfplayer.TabIndex = 2;
            this.numberOfplayer.Text = "Number of Player";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(97, 417);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(87, 31);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.FormattingEnabled = true;
            this.PlayerNumber.Items.AddRange(new object[] {
            "2 ",
            "3 "});
            this.PlayerNumber.Location = new System.Drawing.Point(79, 115);
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.Size = new System.Drawing.Size(123, 21);
            this.PlayerNumber.TabIndex = 5;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(35, 189);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(42, 13);
            this.Player1.TabIndex = 6;
            this.Player1.Text = "Player1";
            this.Player1.Visible = false;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(35, 240);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(42, 13);
            this.Player2.TabIndex = 7;
            this.Player2.Text = "Player2";
            this.Player2.Visible = false;
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(35, 293);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(42, 13);
            this.Player3.TabIndex = 8;
            this.Player3.Text = "Player3";
            this.Player3.Visible = false;
            // 
            // Player1Selection
            // 
            this.Player1Selection.FormattingEnabled = true;
            this.Player1Selection.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Healer",
            "Archer"});
            this.Player1Selection.Location = new System.Drawing.Point(38, 206);
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
            this.Player2Selection.Location = new System.Drawing.Point(38, 258);
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
            this.Player3Selection.Location = new System.Drawing.Point(38, 310);
            this.Player3Selection.Name = "Player3Selection";
            this.Player3Selection.Size = new System.Drawing.Size(121, 21);
            this.Player3Selection.TabIndex = 12;
            this.Player3Selection.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(454, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(640, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(826, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 320);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "UserName";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(79, 67);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(123, 22);
            this.UserNameTextBox.TabIndex = 19;
            this.UserNameTextBox.Text = "";
            // 
            // Mage
            // 
            this.Mage.AutoSize = true;
            this.Mage.Location = new System.Drawing.Point(330, 337);
            this.Mage.Name = "Mage";
            this.Mage.Size = new System.Drawing.Size(34, 13);
            this.Mage.TabIndex = 20;
            this.Mage.Text = "Mage";
            // 
            // Warrior
            // 
            this.Warrior.AutoSize = true;
            this.Warrior.Location = new System.Drawing.Point(526, 337);
            this.Warrior.Name = "Warrior";
            this.Warrior.Size = new System.Drawing.Size(41, 13);
            this.Warrior.TabIndex = 21;
            this.Warrior.Text = "Warrior";
            // 
            // Healer
            // 
            this.Healer.AutoSize = true;
            this.Healer.Location = new System.Drawing.Point(709, 337);
            this.Healer.Name = "Healer";
            this.Healer.Size = new System.Drawing.Size(38, 13);
            this.Healer.TabIndex = 22;
            this.Healer.Text = "Healer";
            // 
            // Archer
            // 
            this.Archer.AutoSize = true;
            this.Archer.Location = new System.Drawing.Point(888, 337);
            this.Archer.Name = "Archer";
            this.Archer.Size = new System.Drawing.Size(38, 13);
            this.Archer.TabIndex = 23;
            this.Archer.Text = "Archer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Normal Attack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Normal Attack:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Normal Attack:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(823, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Normal Attack:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Special Attack:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Special Attack:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(637, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Special Attack";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Special Attack:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Archer);
            this.Controls.Add(this.Healer);
            this.Controls.Add(this.Warrior);
            this.Controls.Add(this.Mage);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player3Selection);
            this.Controls.Add(this.Player2Selection);
            this.Controls.Add(this.Player1Selection);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.PlayerNumber);
            this.Controls.Add(this.numberOfplayer);
            this.Controls.Add(this.CreatePlayer);
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
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox PlayerNumber;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.ComboBox Player1Selection;
        private System.Windows.Forms.ComboBox Player2Selection;
        private System.Windows.Forms.ComboBox Player3Selection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox UserNameTextBox;
        private System.Windows.Forms.Label Mage;
        private System.Windows.Forms.Label Warrior;
        private System.Windows.Forms.Label Healer;
        private System.Windows.Forms.Label Archer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

