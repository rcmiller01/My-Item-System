using UnityEngine;
using System.Collections;


namespace BurgZergArcade.ItemSystem
{
    public interface IISObject
    {
        //name
        string Name { get; set; }
        //value - gold value
        int Value { get; set; }
        //sprite - Icon
        Sprite Icon { get; set; }
        //burden
        int Burden { get; set; }
        //qualitylevel - defined as its own class
        ISQuality Quality { get; set; }

        //questItem flag
    }
}