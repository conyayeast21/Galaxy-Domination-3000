using Rossi_Project_Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy_Domination_3000
{
    class Game
    {
        private Player1 player1;
        private Beans beans;
        private Lightsaber lightsaber;
        private Enemy enemy;
        private Beans beans2;
       
        public Game()
        {
            beans2 = new Black_Beans(); //polymorphism
            player1 = new Player1(100);
            enemy = new Enemy(100);
            beans = new Beans();
            lightsaber = new Lightsaber();
            TitleScreen();
        }
        void TitleScreen()
        {
            string gameArt = @"                     `. ___
                    __,' __`.                _..----....____
        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'
  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'
,'________________                          \`-._`-','
 `._              ```````````------...___   '-.._'-:
    ```--.._      ,.                     ````--...__\-.
            `.--. `-`                       ____    |  |`
              `. `.                       ,'`````.  ;  ;`
                `._`.        __________   `.      \'__/`
                   `-:._____/______/___/____`.     \  `
                               |       `._    `.    \
                               `._________`-.   `.   `.___
                                                  `------'`";
            Console.Write(gameArt);


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "Galaxy Domination 3000: The Greatest Game Ever!";
            Console.WriteLine("\nWelcome to Galaxy Domination 3000, Cadet. This is your Title Screen");
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();
            DescriptionScreen();
        }

        void DescriptionScreen()
        {
            /*
             * PUT YOUR STORY DESCRIPTION AND PLAYER CUSTOMIZATION CODE HERE
             */

            Console.Clear();
            Console.WriteLine("In a galaxy far far away...");
            Console.Write("The Elite Galaxy is filled with criminals and chaos on different planets that aren’t afraid to kill. You and Zeke are humans who are fighting to rule the galaxy and ensure his friends and family on Earth are safe from the dangers of the Elite Galaxy. In the year 3000, spaceships and rockets are accessible on most planets. But on Earth, rockets have been monopolized so you and Zeke had to build your own rocket that has never seen space before. You and Zeke prepare to blast off into space to defeat the Martians who plan to attack Earth in the next 30 days. This has caused governments across Earth to spiral into chaos and nobody has a plan to defeat the Martians besides you and Zeke. Furthermore, other planets are hostile within the Elite Galaxy, so certain decisions can trigger attacks from Jupiter, Neptune, and Pluto. The brotherly love between you and Zeke encourage each other to save their family and possibly leads to tough decisions later in the game... ");
            Console.WriteLine("Press Enter to proceed ");
            Console.ReadLine();

            Console.WriteLine("Enter your height in inches Cadet");
            Console.ReadLine();
            Console.WriteLine("Enter your fighting style Cadet");
            Console.ReadLine();
            Console.WriteLine("Enter your name, Cadet"); //New attributes for cadet
            Console.ReadLine();
            Console.Clear();
            Room1();
        }

        void Room1()
        {
            /*
             * SAMPLE ROOM CODE 
             * PLEASE USE THIS AS A TEMPLATE FOR YOUR GAME ROOMS
             */

            Console.Clear();
            Console.WriteLine("You are at home on Earth staring at your rocket ship that you worked countless hours on");
            Console.WriteLine("Where do you wish to go? (Enter the selection number.)");
            Console.WriteLine("1. Hop in the flight bay and PREPARE FOR LIFTOFF! ");
            Console.WriteLine("2. Check the engine room");

            int selection = Int32.Parse(Console.ReadLine());

            try
            {
                if (selection == 1)
                {
                    Room2();
                }

                else if (selection == 2)
                {
                    Room3();
                }

                else
                {
                    Console.WriteLine("Pick a real choice you silly goose, please press enter to try again.");
                    Console.ReadLine();
                    Room1();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not an integer!");

            }

            void Room2()
            {
                Console.Clear();
                Console.WriteLine("You take a seat next to Zeke in the flight bay and initiate liftoff. Unfortunately you hear a loud boom coming from the engine room and for some reason, it smells like beans. Ah that's right! You spilled your beans in the engine last night! Take em out, put them in your pocket, then return to the flight bay and PREPARE FOR LIFTOFF! ");
                player1.Pickup(beans);
                Console.WriteLine("Press Enter to proceed ");
                Console.ReadLine();
                Console.Clear();
                Room4();
            }

            void Room3()
            {
                Console.Clear();
                Console.WriteLine("What's that on the ground? Wait... there's beans in the engine! Take those silly beans out of the Jumbo Blasters, put them in your pocket, and head back to the flight bay to PREPARE FOR LIFTOFF");
                player1.Pickup(beans);
                Console.WriteLine("Press Enter to proceed ");
                Console.ReadLine();
                Console.Clear();
                Room4();
            }

            void Room4()
            {
                Console.Clear();
                Console.WriteLine("You engage all firepower and BLAST OFF!! You initiate light speed and zoom to mars in a matter of minutes.");
                Console.WriteLine("Where do you wish to go? (Enter the selection number.)");
                Console.WriteLine("1. Martian Swamp of Zabatha");
                Console.WriteLine("2. The Martian Capital, Xenox");
                Console.WriteLine("3. Secret Rebellion Headquarters on Mars, Area 52");

                int selection = Int32.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    Room5();
                }

                else if (selection == 2)
                {
                    Room6();
                }

                else if (selection == 3)
                {
                    Room7();
                }

                else
                {
                    Console.WriteLine("Pick a real choice you silly goose, please press enter to try again.");
                    Console.ReadLine();
                    Room4();
                }
            }
            void Room5()
            {
                Console.Clear();
                Console.WriteLine("After landing in the Swamp of Zabatha, you and Zeke befriend an alligator named Tyrone. He directs you to the Martian Capital, Xenox, and joins you in a quest to reclaim his stolen fedora!");
                Console.WriteLine("Press Enter to proceed ");
                Console.ReadLine();
                Console.Clear();
                Room6();
            }
            void Room6()
            {
                Console.Clear();
                Console.WriteLine("Following a rough landing in Xenox, the Martian Emperor, Muscle Man, confronts you and demands a battle to the DEATH!");
                Console.WriteLine("Choose your weapon: ");
                Console.WriteLine("1. Beans");
                Console.WriteLine("2. Fists");
                Console.WriteLine("3. Lightsaber");
                Console.WriteLine("4. Offer Beans as the Ultimate sign of friendship");

                int selection = Int32.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    player1.BeanAttack(enemy);
                    Console.WriteLine("{0} damage delt to Muscle Man, Muscle man strangles you in anger", Beans.damage);
                }

                else if (selection == 2)
                {
                    player1.Punch(enemy);
                    Console.WriteLine("10 damage delt to Muscle Man, he goes to punch you back, you catch his arm, and slay him with the lightsaber");
                }

                else if (selection == 3)
                {
                    player1.LightsaberAttack(enemy);
                    Console.WriteLine("{0} damage delt to Muscle Man, he instantly disintegrates as his muscles react with the lightsaber", Lightsaber.damage);
                }

                else if (selection == 4)
                {
                    player1.GiveBeans(enemy);
                    enemy.Pickup(beans);
                    Console.WriteLine("Nobody has ever given Muscleman beans before. He cries tears of joy, thanks you, and the universe is at peace.");
                }
                else
                {
                    Console.WriteLine("Pick a real choice you silly goose, please press enter to try again.");
                    Console.ReadLine();
                    Console.ReadLine();
                }
            }
            void Room7()
            {

                //minigame
                Console.Clear();
                int total = 0;
                Console.WriteLine("After landing in the Secret Rebellion Headquarters, Area 52, you find a safe rumored to contain one of the most powerful weapons in the galaxy!");
                Console.WriteLine("The safe has a 10 letter combination lock on it. The directions read, 'In order to receive the weapon yielding light, you must enter the name of the Greatest Game Developer of all days and night!'");
                Console.WriteLine("If you do not answer correctly after 5 tries, the safe will lock");
                Console.WriteLine("Enter the combination ");
                string[] array = { "rossi" };
                string[] combination = array;
                if (total >= 5)
                {
                    Console.WriteLine("The safe locked, head out to Xenox to fight the Martian Emperor");
                }
                if (combination == array)
                {
                    Console.WriteLine("Correct! You now have a LIGHTSABER! Head back to the ship and travel to Xenox to fight the Martian Emperor. ");
                    player1.Pickup(lightsaber);
                    Room6();
                }
                else
                {
                    Console.WriteLine("Incorrect, try again.");
                    total = total + 1;
                }

            }


        }

    }
}