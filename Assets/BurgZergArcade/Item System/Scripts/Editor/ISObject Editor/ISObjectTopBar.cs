using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {

        void TopTabbar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            WeaponTab();
            ArmorTab();
            ConsumablesTab();
            AboutTab();
            GUILayout.EndHorizontal();
        }

        void WeaponTab() {
            GUILayout.Button("Weapons");
        }
        void ArmorTab()
        {
            GUILayout.Button("Armor");

        }
        void ConsumablesTab()
        {
            GUILayout.Button("Consumables");
        }
        void AboutTab()
        {
            GUILayout.Button("About");
        }

    }

}
