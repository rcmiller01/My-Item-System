using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface IISDestructable
    {
        int Durability { get; }
        int MaxDurability { get; }
        void takeDamage(int amount);
        void Break();
        void Repair();

        //durability

        //takeDamage

    }
}
