using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    //Cailey B
    //I'm so sorry :(

    struct Items
    {
        public int itemBoost;
        public string itemName;
        public int itemPrice;
    }

    

    class Game
    {
        public void Continue()
        {
            Console.WriteLine("\nPress [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
        }


        // INPUTS

        public void GetInput(out char input, string option1, string option2, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }
        public void GetInput(out char input, string option1, string option2, string option3, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }

        public void GetInput(out char input, string option1, string option2, string option3, string option4, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("4. " + option4);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }
        public void GetInput(out char input, string quiry)
        {
            Console.WriteLine(quiry);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5' && input != '6')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }


        private Player player;
        private Shop shop;

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
        private Items shopInventory;

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


        public void PrintInventory(Items[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine();
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("Welcome to the shop!");
            PrintInventory();
        }


        public Player CreationPlayer()
         {
            Player player = new Player();
            return player;
         }

        public Shop CreationShop()
        {
            Shop shop = new Shop();
            return shop;
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
            CreationShop();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }

    }
}
