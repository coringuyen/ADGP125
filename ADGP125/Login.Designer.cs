namespace ADGP125
{
    partial class Login
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UseName = new System.Windows.Forms.Label();
            this.UseNameTextBox = new System.Windows.Forms.RichTextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Invalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(70, 134);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(91, 38);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UseName
            // 
            this.UseName.AutoSize = true;
            this.UseName.Location = new System.Drawing.Point(93, 63);
            this.UseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UseName.Name = "UseName";
            this.UseName.Size = new System.Drawing.Size(54, 13);
            this.UseName.TabIndex = 1;
            this.UseName.Text = "UseName";
            // 
            // UseNameTextBox
            // 
            this.UseNameTextBox.Location = new System.Drawing.Point(45, 106);
            this.UseNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UseNameTextBox.Name = "UseNameTextBox";
            this.UseNameTextBox.Size = new System.Drawing.Size(152, 24);
            this.UseNameTextBox.TabIndex = 3;
            this.UseNameTextBox.Text = "";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(70, 239);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(91, 38);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(76, 91);
            this.Invalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(94, 13);
            this.Invalid.TabIndex = 5;
            this.Invalid.Text = "Invalid User Name";
            this.Invalid.Visible = false;
            this.Invalid.Click += new System.EventHandler(this.Invalid_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 338);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UseNameTextBox);
            this.Controls.Add(this.UseName);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UseName;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label Invalid;
        public System.Windows.Forms.RichTextBox UseNameTextBox;
    }
}