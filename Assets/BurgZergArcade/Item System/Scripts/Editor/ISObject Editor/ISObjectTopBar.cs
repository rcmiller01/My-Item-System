using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {

        void TopTabbar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            GUILayout.Button("Weapons");
            GUILayout.Button("Armor");
            GUILayout.Button("Consumables");
            GUILayout.Button("About");
            GUILayout.EndHorizontal();
        }
    }
}
