using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade
{

    public class ScriptableObjectDatabase<T> : ScriptableObject where T: class
    {
        [SerializeField] List<T> database = new List<T>();

        public void Add(T item)
        {
            database.Add(item);
            EditorUtility.SetDirty(this);

        }

        public void Insert(int index, T item)
        {
            database.Insert(index, item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(T item)
        {
            database.Remove(item);
            EditorUtility.SetDirty(this);

        }

        public void Remove(int index)
        {
            database.RemoveAt(index);
            EditorUtility.SetDirty(this);
        }

        public int Count
        {
            get { return database.Count; }
        }

        public T Get(int index)
        {
            return database.ElementAt(index);
        }

        public void Replace(int index, T item)
        {
            database[index] = item;
            EditorUtility.SetDirty(this);
        }

        public U GetDatabase<U>(string databasePath, string databaseName) where U : ScriptableObject
        {
            string databaseFullPath = @"Assets/" + databasePath + "/" + databaseName;

            U db = AssetDatabase.LoadAssetAtPath(databaseFullPath, typeof(U)) as U;

            if (db == null)
            {
                //check to see if the folder exists
                if (!AssetDatabase.IsValidFolder("Assets/" + databasePath))
                    AssetDatabase.CreateFolder("Assets", databasePath);

                //create the database and refresh the assets database
                db = ScriptableObject.CreateInstance<U>() as U;
                AssetDatabase.CreateAsset(db, databaseFullPath);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();

            }
            return db;
        }


        }
}
