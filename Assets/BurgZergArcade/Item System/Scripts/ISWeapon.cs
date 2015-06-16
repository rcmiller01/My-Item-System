using UnityEngine;
using UnityEditor;
using System.Collections;
using System;

namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquippable, IISEquipmentSlot, IISGameObject
    {
        [SerializeField] int _minDamage;
        [SerializeField] int _durability;
        [SerializeField] int _maxDurability;
        [SerializeField] ISEquipmentSlot _equipmentSlot;
        [SerializeField]
        GameObject _prefab;


        public ISWeapon()
        {
            _equipmentSlot = new ISEquipmentSlot();
            //_prefab = new GameObject();
        }
        public ISWeapon (int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
        {
            _durability = Value;
            _maxDurability = MaxDurability;
            _equipmentSlot = equipmentSlot;
            _prefab = prefab;
        }


        public int MinDamage
        {
            get { return _minDamage; }


            set { _minDamage = value; }
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public int Durability
        {
            get
            {
                return _durability;
            }
        }

        public int MaxDurability
        {
            get { return _maxDurability; }
        }

        public void takeDamage(int amount)
        {
            _durability -= amount;
            if (_durability < 0)
                _durability = 0;

            if (_durability == 0)
                Break();
        }

        //reduce the durability to 0
        public void Break()
        {
            _durability = 0;
            
        }

        public void Repair()
        {
            _maxDurability--;
            if(_maxDurability > 0)

                _durability = _maxDurability;
        }

        public ISEquipmentSlot EquipmentSlot
        {
            get { return _equipmentSlot; }
        }

        public GameObject Prefac
        {
            get
            {
                return _prefab;
            }
        }

        public bool Equip()
        {
            throw new NotImplementedException();
        }

        //this code will go into a new script later

        public override void OnGUI()
        {
            base.OnGUI();
            _minDamage = System.Convert.ToInt32(EditorGUILayout.TextField("Damage: ", _minDamage.ToString()));
            _durability = System.Convert.ToInt32(EditorGUILayout.TextField("Durability: ", _durability.ToString()));
            _maxDurability = System.Convert.ToInt32(EditorGUILayout.TextField("Max Durability: ", _maxDurability.ToString()));

            DisplayEquipmentSlot();
            DisplayPrefab();

    }
        public void DisplayEquipmentSlot()
        {
            GUILayout.Label("Equipment Slot");
        }

        public void DisplayPrefab()
        {
            GUILayout.Label("Prefab");
        }

    }
}
