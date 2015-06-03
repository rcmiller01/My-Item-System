using UnityEngine;
using System.Collections;


namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISQuality : IISQuality
    {
        [SerializeField]
        string _name;
        [SerializeField]
        Sprite _Icon;

        public ISQuality()
        {
            _name = "Common";
            _Icon = new Sprite();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Sprite Icon
        {
            get { return _Icon; }
            set { _Icon = value; }

        }
    }
}