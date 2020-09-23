using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private Items[] _shopInventory;

        public Shop()
        {
            _shopInventory = new Items[9];
            _gold = 10;
        }
        public Shop(int inventorySize, int currency)
        {
            _shopInventory = new Items[inventorySize];
            _gold = currency;
        }


        public bool Sell(Player _player, int shopIndex, int playerIndex)
        {
            return _player.Buy(Player._inventory[shopIndex], playerIndex); //don't know what to do to fix this and where this should go
        }

    }
}
