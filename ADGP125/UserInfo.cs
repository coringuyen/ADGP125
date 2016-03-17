using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    [Serializable()]
    class UserInfo
    {
        public string Name, Gender, Race;
        public int Age;

        public UserInfo(string name, string gender, string race, int age)
        {
            Name = name;
            Gender = gender;
            Race = race;
            Age = age;
        } 
    }
}
