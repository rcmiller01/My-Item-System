using UnityEngine;
using UnityEditor;
using System.Collections;


namespace BurgZergArcade.ItemSystem
{

    [System.Serializable]

    public class ISObject : IISObject
    {
        [SerializeField] Sprite _Icon;
        [SerializeField] string _name;
        [SerializeField] int _value;
        [SerializeField] int _burden;
        [SerializeField] ISQuality _quality;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Sprite Icon
        {
            get { return _Icon; }
            set { _Icon = value; }
        }
        public int Burden
        {
            get { return _burden; }
            set { _burden = value; }
        }
        public ISQuality Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public virtual void OnGUI()
        {
            GUILayout.BeginVertical();
            Name = EditorGUILayout.TextField("Name: ", Name);
            _value =System.Convert.ToInt32( EditorGUILayout.TextField("Value: ", _value.ToString()));
            _burden = System.Convert.ToInt32(EditorGUILayout.TextField("Burden: ", _burden.ToString()));
            DisplayIcon();
            DisplayQuality();
            GUILayout.EndVertical();
        }

        public void DisplayIcon()
        {
            GUILayout.Label("Icon");
        }
        public void DisplayQuality()
        {
            GUILayout.Label("Quality");
        }
    }
}
