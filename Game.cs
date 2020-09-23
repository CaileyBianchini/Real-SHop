using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{


    struct Items
    {
        public int itemBoost;
        public string itemName;
        public int itemPrice;
    }

    class Game
    {

        private Items _longSword;
        private Items _sheild;
        private Items _mace;
        private Items _BowAndArrow;

        private Items _Gem;
        private Items _fireGem;

        private Items _poisonPotion;
        private Items _fearPotion;
        private Items _fartPotion;

        private Items _money;

        private Player _player;

        public void InitializeItems()
        {
            _longSword.itemBoost = 15;
            _longSword.itemName = "Long Sword";
            _longSword.itemPrice = 2;

            _sheild.itemBoost = 10;
            _sheild.itemName = "Sheild";
            _sheild.itemPrice = 1;


            _mace.itemBoost = 17;
            _mace.itemName = "Mace";
            _mace.itemPrice = 4;

            _BowAndArrow.itemBoost = 9;
            _BowAndArrow.itemName = "Bow and Arrow";
            _BowAndArrow.itemPrice = 1;

            //items
            _money.itemPrice = 10;

            //Gem
            _Gem.itemPrice = 2;
            _Gem.itemName = "Gem";
            _Gem.itemBoost = 15;

            _fireGem.itemPrice = 1;
            _fireGem.itemName = "Fire Gem";
            _fireGem.itemBoost = 10;

            //Potions
            _poisonPotion.itemPrice = 2;
            _poisonPotion.itemName = "Poison Potion";
            _poisonPotion.itemBoost = 20;

            _fearPotion.itemPrice = 2;
            _fearPotion.itemName = "Fear Potion";
            _fearPotion.itemBoost = 10;

            _fartPotion.itemPrice = 5;
            _fartPotion.itemName = "Fart Potion";
            _fartPotion.itemBoost = 100;

        }


        public void PrintInventory()
        {
            foreach(Items item in _player.GetInventory())
            {
                //Console.WriteLine(_inventory);
            }
        }


        private void OpenShopMenu()
        {

        }

        private shopInventory(Items[])
        {

        }

        //Run the game
        public void Run()
        {
            Start();
            Update();
        }

        //Performed once when the game begins
        public void Start()
        {
            
        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
