using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        //private string _name;
        private int _baseDamage;
        private Items[] _inventory;
        private Items _hands;
        private int _gold;

        

        public Player()
        {
            _baseDamage = 5;
            _inventory = new Items[3];
            _hands.itemBoost = 0;
            _hands.itemName = "Palm";
            _gold = 10;
            
        }

        public Player(/*string nameVal,*/int damageVal, int inventorySize, int coins)
        {
            //_name = nameVal;
            _baseDamage = damageVal;
            _inventory = new Items[inventorySize];
            _hands.itemName = "Palm";
            _hands.itemBoost = 0;
            _gold = coins;
        }

        public void AddItemToInventory(Items item, int index)
        {
            _inventory[index] = item;

        }

        public Items[] GetInventory()
        {
            return _inventory;
        }



        public bool Buy(Items item, int Item)
        {
            return _gold > 0;
        }

        //Unneeded
        //public string GetName()
        //{
        //    return _name;
        //}


    }
}
