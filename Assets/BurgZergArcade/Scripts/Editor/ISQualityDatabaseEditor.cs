using UnityEngine;
using System.Collections;
using UnityEditor;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow {

        ISQualityDatabase db;

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
            db = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ISQualityDatabase)) as ISQualityDatabase;

            if (db == null)
            {
                if (AssetDatabase.IsValidFolder("Assets/" + DATBASE_FOLDER_NAME))
                    AssetDatabase.CreateFolder("Assets", DATBASE_FOLDER_NAME);
                  
                    db = ScriptableObject.CreateInstance<ISQualityDatabase>();
                    AssetDatabase.CreateAsset(db, DATABASE_FULL_PATH);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
       
            }          
        }

    }
}