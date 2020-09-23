using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int gold;
        private Items[] _shopInventory;
        private Items[] _inventory;

        Shop()
        {

        }
        Shop(Items[])
        {

        }

        public bool Sell(Player _player, int shopIndex, int playerIndex)
        {
            return _player.Buy(Player._inventory[shopIndex], playerIndex); //don't know what to do to fix this and where this should go
        }



    }
}
