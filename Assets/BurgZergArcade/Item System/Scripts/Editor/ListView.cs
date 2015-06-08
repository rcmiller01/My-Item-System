using UnityEngine;
using UnityEditor;
using System.Collections;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor
    {

        //list all of the stored qualitites in the database
        void ListView()
        {
            //GUILayout.Label("Displayed");  test
            _scrollPos =  EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));

            DisplayQualities();

            EditorGUILayout.EndScrollView();
        }
        
        void DisplayQualities()
        {
            for (int cnt = 0; cnt < qualityDatabase.Count; cnt++)
            {
                if (qualityDatabase.Get(cnt).Icon)
                    selectedTexture = qualityDatabase.Get(cnt).Icon.texture;
                else
                    selectedTexture = null;

                if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                    {
                        int controlerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                        EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlerID);
                        selectedIndex = cnt;
                    }

                string commandName = Event.current.commandName;
                if (commandName == "ObjectSelectorUpdated")
                    {
                    if (selectedIndex != -1)
                    {

                        qualityDatabase.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        selectedIndex = -1;
                    }
                    Repaint();
                }
                //name
                qualityDatabase.Get(cnt).Name =  GUILayout.TextField( qualityDatabase.Get(cnt).Name);
                GUILayout.Button("x");
            }
        }
    }
}
