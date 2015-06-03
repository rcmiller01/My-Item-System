﻿using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow {

        ISQualityDatabase qualityDatabase;
        ISQuality selectedItem;
        Texture2D selectedTexture;


        const int SPRITE_BUTTON_SIZE = 92;

        const string DATABASE_FULL_PATH = @"Assets/" + DATBASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME;
        const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
        const string DATBASE_FOLDER_NAME = @"Database";

        [MenuItem("BZA/Database/Quality Editor %#i")]

        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Quality DB";
            window.Show();
        }
        void OnEnable()
        {
            qualityDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

            if (qualityDatabase == null)
            {
                if (AssetDatabase.IsValidFolder("Assets/" + DATBASE_FOLDER_NAME))
                    AssetDatabase.CreateFolder("Assets", DATBASE_FOLDER_NAME);
                  
                    qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
                    AssetDatabase.CreateAsset(qualityDatabase, DATABASE_FULL_PATH);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
       
            }
            selectedItem = new ISQuality();
        }


        void OnGUI()
        {
            AddQualityToDatabase();

        }

        void AddQualityToDatabase()
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
                qualityDatabase.db.Add(selectedItem);

                selectedItem = new ISQuality();
            }
        }

    }
}