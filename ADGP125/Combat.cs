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
    public partial class HealthLabel : Form
    {
        
        Serialization<Player> player = new Serialization<Player>();

        public HealthLabel()
        {
            InitializeComponent();
            LoadPlayers();
        }

        

        void LoadPlayers()
        {
            Login form = new Login();
            Player players = player.Deserialize("tranKiller.xml");
            Player1C.Text = players.characterType[0];
            Player2C.Text = players.characterType[1];


            string player1 = Player1C.Text;
            pictureBox1.Image = Image.FromFile(@"../../characterPicture/" + player1 + ".png");
            pictureBox2.Image = Image.FromFile(@"../../characterPicture/Mage.png");
        }
    }
}
