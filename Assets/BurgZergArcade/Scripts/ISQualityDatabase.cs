using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade.ItemSystem
{

    public class ISQualityDatabase : ScriptableObject
    {
        [SerializeField]
        List<ISQuality> db = new List<ISQuality>();
    }
}
