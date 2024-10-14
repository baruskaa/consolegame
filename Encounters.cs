using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    internal class Encounters
    {

        static Random rand = new Random();


        //Encounter
        public static void encounterLouise()
        {
            //louise screaming-battle scene
            Console.WriteLine("INSERT NARRATION NI LOUISE");
            Console.ReadKey();
            combat(false, "The Dark Creature", 1, 4);
            Console.WriteLine("INSERT NARRATION NI LOUISE -CONTEXT GIVING + looted enemy and given new sword");
            recieveAmulet("Coolest Amulet");
            recieveWeapon("Coolest Sword");

            upgradeAmulet("Coolest Amulet");
            upgradeWeapon("Coolest Sword");
        }

        // Events
        public static void combat(bool random, String name, int power, int health)
        {
            String enemyName = "";
            int enemyPower = 0;
            int enemyHealth = 0;
            if (random){}
            else
            {
                enemyName = name;
                enemyPower = power;
                enemyHealth = health;
            }

            while (enemyHealth > 0)
            {

                Console.WriteLine("\nENEMY NAME: " + enemyName + "\nENEMY POWER: " + enemyPower + "\nENEMY HEALTH: " + enemyHealth + "\n");

                Console.WriteLine("*============================*");
                Console.WriteLine("|| (1) Attack    (2) Defend ||");
                Console.WriteLine("|| (3) Run       (4) Heal   ||");
                Console.WriteLine("*============================*");
                Console.WriteLine("POTIONS: " + Program.player1.potionCount + "\nHEALTH: " + Program.player1.health + "\n");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    int damage, attack;

                    switch (input)
                    {
                        case 1:
                            //atk

                            damage = enemyPower - Program.player1.amuletValue;
                            if (damage < 0) { damage = 0; }
                            attack = rand.Next(0, Program.player1.weaponValue) + rand.Next(1, 4);

                            Console.WriteLine("you attacked " + enemyName + ". you lose " + damage + " health and deal " + attack + "damage.");

                            Program.player1.health -= damage;
                            enemyHealth -= attack;

                            break;

                        case 2:

                            //def

                            damage = (enemyPower / 4) - Program.player1.amuletValue;
                            if (damage < 0) { damage = 0; }
                            attack = rand.Next(0, Program.player1.weaponValue) / 2;

                            Console.WriteLine("you defended yourself from " + enemyName + ". you lose " + damage + " health and deal " + attack + "damage.");

                            Program.player1.health -= damage;
                            enemyHealth -= attack;


                            break;

                        case 3:

                            //run
                            if (rand.Next(0, 2) == 0)
                            {
                                //fail 
                                damage = enemyPower - Program.player1.amuletValue;
                                if (damage < 0) { damage = 0; }
                                Console.WriteLine(" you lose " + damage + "as you failed to escape " + enemyName);
                                Program.player1.health -= damage;

                            }
                            else
                            {
                                //success 
                                damage = enemyPower - Program.player1.amuletValue;
                                if (damage < 0) { damage = 0; }
                                Console.WriteLine("You managed to escape " + enemyName + ".");
                            }

                            break;

                        case 4:

                            //heal

                            if (Program.player1.potionCount == 0)
                            {
                                //no potion, take damage
                                damage = enemyPower - Program.player1.amuletValue;
                                if (damage < 0) { damage = 0; }
                                Console.WriteLine("you don't have any potions. " + enemyName + " strikes you and you lose " + damage + " health.");
                                Program.player1.health -= damage;
                            }
                            else
                            {
                                //drink potion, add health
                                int potionValue = 2;
                                Console.WriteLine("You drink a potion and gain " + potionValue + " health");
                                Program.player1.health += potionValue;

                            }

                            break;

                        default:
                            Console.WriteLine("INVALID INPUT!");
                            break;


                    }

                    if(Program.player1.health <= 0)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("YOU DIED");
                                Console.WriteLine("☠☠☠☠☠");
                                Console.Write("Do you wish to restart the game? [Y or N]: ");
                                String ans = Console.ReadLine();
                                if (ans.ToUpper() == "Y")
                                {

                                    Console.Clear();
                                    Program.player1.resetAttributes();  
                                    Program.Start();
                                }
                                else if (ans.ToUpper() == "N")
                                {
                                    Console.WriteLine("\nThank You For Playing.\n");
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("INVALID INPUT");
                                    Console.Clear();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("INVALID INPUT");
                            }
                        }
                    }
                } catch(Exception e) {Console.WriteLine("INVALID INPUT!"); }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("You have successfully beaten " + enemyName + "!");
            }
        }


        public static void recieveWeapon(String weaponName)
        {
            Console.WriteLine("\nITEM AQUIRED: " + weaponName);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Damage: " + Program.player1.weaponValue + "                       |");
            Console.WriteLine("-----------------------------------");
        }

        public static void recieveAmulet(String amuletName)
        {
            Console.WriteLine("\nITEM AQUIRED: " + amuletName);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Defense: " + Program.player1.amuletValue + "                      |");
            Console.WriteLine("-----------------------------------");
        }

        public static void upgradeWeapon(String weaponName)
        {
            Program.player1.weaponValue += 2;
            Console.WriteLine("\nWEAPON UPGRADED: " + weaponName);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Damage: " + Program.player1.weaponValue + "                       |");
            Console.WriteLine("-----------------------------------");
        }

        public static void upgradeAmulet(String amuletName)
        {
            Program.player1.amuletValue += 2;
            Console.WriteLine("\nAMULET UPGRADED: " + amuletName);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Defense: " + Program.player1.amuletValue + "                      |");
            Console.WriteLine("-----------------------------------");
        }


    }
}
