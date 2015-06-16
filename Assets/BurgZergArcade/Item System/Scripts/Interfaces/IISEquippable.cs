using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{

    public interface IISEquippable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        //equip slot
        bool Equip();

    }

}
