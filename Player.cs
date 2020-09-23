using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        //private string _name;
        private int _health;
        private int _baseDamage;
        private Items[] _inventory;
        private Items _currentWeapon;
        private Items _hands;
        private Items _gold;

        

        public Player()
        {
            _health = 100;
            _baseDamage = 5;
            _inventory = new Items[3];
            _hands.itemBoost = 0;
            _hands.itemName = "Palm";
            
        }

        public Player(/*string nameVal,*/int healthVal, int damageVal, int inventorySize)
        {
            //_name = nameVal;
            _health = healthVal;
            _baseDamage = damageVal;
            _inventory = new Items[inventorySize];
            _hands.itemName = "Palm";
            _hands.itemBoost = 0;
        }

        public void AddItemToInventory(Items item, int index)
        {
            _inventory[index] = item;

        }

        public Items[] GetInventory()
        {
            return _inventory;
        }

        public bool Buy(Items, int)
        {
            Items[] inventory = { };
            
        }


        //Unneeded
        //public string GetName()
        //{
        //    return _name;
        //}


    }
}
