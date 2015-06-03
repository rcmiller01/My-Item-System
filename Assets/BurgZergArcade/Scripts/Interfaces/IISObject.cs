using UnityEngine;
using System.Collections;

public interface IISObject {
    //name
    string ISName { get; set; }
    //value - gold value
    int ISValue { get; set; }
    //sprite - Icon
    Sprite ISIcon { get; set; }
    //burden
    int ISBurden { get; set; }
    //qualitylevel - defined as its own class
    ISQuality ISQuality { get; set; }

    //
    //these go to other item interfaces
    //equip
    //questItem flag
    //durability
    //takeDamage
    //prefab

}
