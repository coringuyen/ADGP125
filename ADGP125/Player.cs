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
        public string[] characterType;
        protected int numberofPlayer;

        public Player(int number_of_player, string[] Type)
        {
            characterType = Type;
            numberofPlayer = number_of_player;
        }
    }
}
