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
        Serialization<Player> SerializeUser = new Serialization<Player>();
        Player user;

        public Form1()
        {
            InitializeComponent();
            Addlabel_addComboBox();
        }
        

        private void load(object sender, EventArgs e)
        {
            user = SerializeUser.Deserialize("UserInfo.bin");
        }

        List<Label> playersLabel = new List<Label>();
        List<ComboBox> playersSelection = new List<ComboBox>();

        private void Addlabel_addComboBox()
        {
            playersLabel.Add(Player1);
            playersLabel.Add(Player2);
            playersLabel.Add(Player3);
            playersLabel.Add(Player4);

            playersSelection.Add(Player1Selection);
            playersSelection.Add(Player2Selection);
            playersSelection.Add(Player3Selection);
            playersSelection.Add(Player4Selection);
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; ++i)
            {
                playersLabel[i].Visible = false;
                playersSelection[i].Visible = false;
            }

            if (PlayerNumber.Text != null)
            {
                int numberofPlayer = int.Parse(PlayerNumber.Text);

                for (int i = 0; i < numberofPlayer; ++i)
                {
                    playersLabel[i].Visible = true;
                    
                    playersSelection[i].Visible = true;
                    playersSelection[i].Text = null;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int numberofPlayer = int.Parse(PlayerNumber.Text);
            string[] player_type = new string[numberofPlayer];

            for (int i = 0; i < numberofPlayer; ++i)
            {
                player_type[i] = playersSelection[i].Text;
            }

            user = new Player(numberofPlayer, player_type);
            SerializeUser.Serialize(UserNameTextBox.Text + ".xml", user);

            Login f = new Login();
            this.Hide();
            f.Show();
            
        }
    }
}
