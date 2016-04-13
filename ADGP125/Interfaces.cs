﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    interface IStat
    {
        int health { get; }
    }

    interface IDamager
    {
        int damage { get; }
    }

    interface IAbility
    {
        void nomalAttack(int damge);
        void specialAttack(int damage);
    }

}
