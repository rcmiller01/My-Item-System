using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{

    public interface ISStackable
    {
        //stack size
        int Stack(int amount);  //default value of zero
        int MaxStack { get; }


    }
}
