using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{

    public interface ISEquippable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        //equip slot
        bool Equip();

    }

}
