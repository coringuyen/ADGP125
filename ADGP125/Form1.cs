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
            //load();
        }
        

        private void load(object sender, EventArgs e)
        {
            user = SerializeUser.Deserialize("UserInfo.bin");
            //label1.Text = user.Name;
        }

        List<Label> playersLabel = new List<Label>();
        List<ComboBox> playersSelection = new List<ComboBox>();

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            int numberofPlayer = int.Parse(PlayerNumber.Text);

            playersLabel.Add(Player1);
            playersLabel.Add(Player2);
            playersLabel.Add(Player3);
            playersLabel.Add(Player4);

            playersSelection.Add(Player1Selection);
            playersSelection.Add(Player2Selection);
            playersSelection.Add(Player3Selection);
            playersSelection.Add(Player4Selection);

            for (int i = 0; i < numberofPlayer; ++i)
            {
                Label playerlabel = playersLabel[i];
                playerlabel.Visible = true;

                ComboBox playerSelection = playersSelection[i];
                playerSelection.Visible = true;
                playerSelection.Text = null;
            }

           
        }

        private void Play_Click(object sender, EventArgs e)
        {
            int numberofPlayer = int.Parse(PlayerNumber.Text);
            string[] player_type = new string[numberofPlayer];
            string[] player_order = new string[numberofPlayer];

            for (int i = 0; i < numberofPlayer; ++i)
            {
                string player = "Player" + i;
                ComboBox playerSelection = playersSelection[i];
                player_order[i] = player;
                player_type[i] = playerSelection.Text;
            }


            user = new Player(numberofPlayer, player_type, player_order);
            SerializeUser.Serialize("UserInfo.xml", user);
            
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }
    }
}
