using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {

        ISQualityDatabase qualityDatabase;
//      ISQuality selectedItem;
        Texture2D selectedTexture;
        Vector2 _scrollPos;     //scroll position for ListView
        int selectedIndex = -1;

        const int SPRITE_BUTTON_SIZE = 46;

        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;
        const string DATABASE_NAME = @"bzaQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";

        [MenuItem("BZA/Database/Quality Editor %#i")]

        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            //window.titleContent = "Quality DB";
            window.title = "Quality DB";  //deprecated
            window.Show();
        }
        void OnEnable()
        {
            qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
            qualityDatabase = qualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);


        }


        void OnGUI()
        {
            if(qualityDatabase == null)
            {
                Debug.LogWarning("qualityDatabase not loaded");
                return;
            }
            ListView();
            //AddQualityToDatabase(); removed episode 8
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();

        }

        void BottomBar()
        {
            //count
            GUILayout.Label("Qualities:"+qualityDatabase.Count);

            //addbutton
            if (GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }

        }

        /***        void AddQualityToDatabase()
                {
                    //name
                    selectedItem.Name = EditorGUILayout.TextField("Name:", selectedItem.Name);
                    //sprite
                    if (selectedItem.Icon)
                        selectedTexture = selectedItem.Icon.texture;
                    else
                        selectedTexture = null;

                   if( GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE),GUILayout.Height(SPRITE_BUTTON_SIZE)))
                    {
                        int controlerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                        EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlerID);
                    }

                    string commandName = Event.current.commandName;
                    if(commandName == "ObjectSelectorUpdated")
                    {
                        selectedItem.Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        Repaint();
                    }

                    if (GUILayout.Button("Save"))
                        {
                        if (selectedItem == null)
                            return;

                        if (selectedItem.Name == "")
                            return;

                        qualityDatabase.Add(selectedItem);
                        //qualityDatabase.db.Add(selectedItem);

                        selectedItem = new ISQuality();
                    } 
                } ***/

    }
}