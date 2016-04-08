using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ADGP125
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();
            this.Hide();
            register.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(@"..\..\SavedFiles\" + UseNameTextBox.Text + ".xml") == false)
            {
                Invalid.Visible = true;
            }
            else
            {
                Invalid.Visible = false;
                Form2 enemyState = new Form2();
                this.Hide();
                enemyState.Show();
            }
        }

        private void Invalid_Click(object sender, EventArgs e)
        {

        }
    }
}
