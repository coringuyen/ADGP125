using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Handler();
public delegate void CallBack();

namespace ADGP125
{
    
    class FSM<T>
    {
        Dictionary<string, Delegate> transitionTable = new Dictionary<string, Delegate>();
        List<T> listofstate = new List<T>();

        //public T currentState;

        
    }
}
