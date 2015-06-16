using UnityEngine;
using UnityEditor;
using System.Collections;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        ISWeaponDatabase weaponDatabase;
        
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;
        const string DATABASE_NAME = @"bzaWeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";


        [MenuItem("BZA/Database/Item System Editor %#i")]

        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.title = "Item System";  //deprecated
            window.Show();
        }

        void OnEnable() {
            if (weaponDatabase == null)
            {
                //qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
                weaponDatabase = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
            }
        }
        void OnGUI()
        {

            TopTabbar();

            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();
            BottomStatusBar();

        }

    }
}
