using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{

    public partial class ISObjectEditor
    {
        ISWeapon tempWeapon = new ISWeapon();
        bool showNewWeaponDetails = false;



        void ItemDetails()
        {
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            //GUILayout.Label("Detail View");
            if (showNewWeaponDetails)
                DisplayNewWeapon();
 

            GUILayout.EndVertical();


            GUILayout.Space(25);
            //GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            DisplayButtons();
            //GUILayout.EndHorizontal();
            GUILayout.EndVertical();

            //name
            //value
        }



        void DisplayNewWeapon() {
            tempWeapon.OnGUI();
 
        }
        void DisplayButtons()
        {
            if (!showNewWeaponDetails)
            {
                if (GUILayout.Button("Create Weapon"))

                {
                    tempWeapon = new ISWeapon();
                    showNewWeaponDetails = true;
                }
            }
            else
            {
                if (GUILayout.Button("Save"))
                {
                    showNewWeaponDetails = false;
                    tempWeapon = null;
                }
                if (GUILayout.Button("Cancel"))
                {
                    showNewWeaponDetails = false;
                    tempWeapon = null;
                }
            }
            }

        }

    }

