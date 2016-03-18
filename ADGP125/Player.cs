using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    [Serializable()]
    class Player
    {
        private string[] characterType;
        private string[] playerOrder;
        private int numberofPlayer;

        public Player(int number_of_player, string[] Type, string[] PlayerOrder)
        {
            characterType = Type;
            playerOrder = PlayerOrder; 
            numberofPlayer = number_of_player;
        }
    }
}
