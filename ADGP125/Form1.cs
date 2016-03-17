using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP125
{
    public partial class Form1 : Form
    {
        Serialization<UserInfo> SerializeUser = new Serialization<UserInfo>();
        UserInfo user;

        public Form1()
        {
            InitializeComponent();
            //load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user = new UserInfo(UserName.Text, Gender.Text, Race.Text, (int)Age.Value);
            SerializeUser.Serialize("UserInfo.xml", user);

            //Form2 f = new Form2();
            //this.Hide();
            //f.Show();
        }

        private void load()
        {
            user = SerializeUser.Deserialize("UserInfo.bin");
            UserName.Text = user.Name;
        }

    }
}
