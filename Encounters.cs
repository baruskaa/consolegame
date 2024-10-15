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
            Console.WriteLine();
            Program.centerPara("It's just another day in the woods. The same familiar scent of");
            Program.centerPara("oak and the sound of your axe splitting through the wood.");
            Console.WriteLine();
            Program.centerPara("You pause for a moment, taking in the peaceful atmosphere.");
            Console.WriteLine();
            Program.centerPara("Everything seems normal. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("Suddenly, a high-pitched scream echoes through the trees,");
            Program.centerPara("cutting through the peaceful atmosphere like a knife. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("║                                                            ║");
            Program.centerPara("║  ???: AAAAAAHHHHHH!!!!!!                                   ║");
            Program.centerPara("║                                                            ║");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("You freeze, gripping your axe tighter.");
            Console.WriteLine();
            Program.centerPara("That scream… It’s coming from deeper in the forest.");
            Console.WriteLine();
            Program.centerPara("It’s desperate, terrified.");
            Console.WriteLine();
            Program.centerPara("Someone’s in trouble. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("║                                                            ║");
            Program.centerPara("║  ???: HELP!!! PLEASE, SOMEONE!!!!                          ║");
            Program.centerPara("║                                                            ║");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("As you approach the area, you see her——a woman sprinting as fast");
            Program.centerPara("as her legs can carry her, a terrified expression on her face.");
            Console.WriteLine();
            Program.centerPara("And behind her... >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("A gigantic beast, twisted and inhumane, is drawing near upon her.");
            Program.centerPara("Its massive claws cutting through the underbrush. She’s moments");
            Program.centerPara("away from being caught. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("You have no weapon but your axe—an ordinary woodcutter’s tool.");
            Console.WriteLine();
            Program.centerPara("But it’s enough.");
            Console.WriteLine();
            Program.centerPara("It has to be. >>>");
            Console.ReadKey();
            Console.Clear();

            combat(false, "Monstrous Beast", 2, 4);

            Console.WriteLine();
            Program.centerPara("As you approach the area, you see her——a woman sprinting as fast");
            Program.centerPara("as her legs can carry her, a terrified expression on her face.");
            Console.WriteLine();
            Program.centerPara("And behind her... >>>");
            Console.ReadKey();
            Console.Clear();


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

            int totalEnergy = Program.player1.energy;
            int totalAttack = rand.Next(0, Program.player1.weaponValue);

            if (random){}
            else
            {
                enemyName = name;
                enemyPower = power;
                enemyHealth = health;
            }

            while (enemyHealth > 0)
            {
                Console.WriteLine();
                Program.centerPara("ENEMY NAME: " + enemyName);
                Program.centerPara("ENEMY POWER: " + enemyPower);
                Program.centerPara("ENEMY HEALTH: " + enemyHealth);
                Console.WriteLine();

                Program.centerPara("oo=============================oo");
                Program.centerPara("||    (A)ttack     (D)efend    ||");
                Program.centerPara("||    (R)un        (H)eal      ||");
                Program.centerPara("oo=============================oo");
                Console.WriteLine();
                Program.centerPara("HEALTH: " + Program.player1.health);
                Program.centerPara("ENERGY: " + totalEnergy);
                Program.centerPara("POTIONS: " + Program.player1.potionCount);
                Console.WriteLine("\n");
                try
                {
                    if (totalEnergy <= 0)
                    {
                        Program.centerPara("You ran out of energy to fight. Your attacks will deal less damage now.");
                        totalAttack -= 2;
                        if (totalAttack < 0) { totalAttack = 0; }
                        Console.WriteLine();
                    }

                    string input = Program.centerInput("What would you do?");
                    Console.WriteLine();
                    int damage = enemyPower - Program.player1.amuletValue;
                    int energy, attack;
                    
                    

                    switch (input)
                    {
                        case "A":
                            //atk
                            if (damage < 0) { damage = 0; }
                            attack = totalAttack + rand.Next(1, 4);
                            energy = 2;

                            Program.centerPara("You attacked " + enemyName + ".");
                            Program.centerPara("You lose " + damage + " health, " + energy + " energy, and deal " + attack + " damage.");

                            Program.player1.health -= damage;
                            enemyHealth -= attack;
                            totalEnergy -= energy;
                            if (totalEnergy < 0) { totalEnergy = 0; }

                            break;

                        case "D":

                            //def

                            damage = (enemyPower / 4) - Program.player1.amuletValue;
                            if (damage < 0) { damage = 0; }
                            attack = totalAttack / 2;
                            energy = 1;

                            Program.centerPara(enemyName + " attacked you, but you managed to defend yourself.");
                            Program.centerPara("You lose " + damage + " health, " + energy + " energy, and deal " + attack + " damage.");

                            Program.player1.health -= damage;
                            enemyHealth -= attack;
                            totalEnergy -= energy;
                            if (totalEnergy < 0) { totalEnergy = 0; }

                            break;

                        case "R":

                            //run
                            if (rand.Next(0, 2) == 0)
                            {
                                //fail, take damage 
                                if (damage < 0) { damage = 0; }
                                energy = 1;
                                Program.centerPara(enemyName + " catches up and attacks you.");
                                Program.centerPara("You lose " + damage + " health and " + energy + " energy");
                                Program.player1.health -= damage;
                                totalEnergy -= energy;
                                if (totalEnergy < 0) { totalEnergy = 0; }
                            }
                            else
                            {
                                //success , add energy
                                energy = 1;
                                if (damage < 0) { damage = 0; }
                                Program.centerPara("You managed to escape " + enemyName + ". You take a few breaths to regain some energy.");
                                totalEnergy += energy;
                                if (totalEnergy < 0) { totalEnergy = 0; }
                            }

                            break;

                        case "H":

                            //heal
                            if (Program.player1.potionCount == 0)
                            {
                                // No potion, take damage
                                if (damage < 0) { damage = 0; }
                                Program.centerPara("You don't have any potions.");
                                Program.centerPara("While you were looking for a potion, " + enemyName + " strikes you");
                                Program.centerPara("and you lose " + damage + " health.");
                                Program.player1.health -= damage;
                            }
                            else
                            {
                                // Drink potion, add health
                                int potionValue = 2;
                                energy = 3;

                                Program.centerPara("You drink a potion and gain " + energy + " energy and " + potionValue + " health.");
                                Program.player1.health += potionValue;
                                totalEnergy += energy;

                                // Decrease potion count
                                Program.player1.potionCount--;

                                // Ensure total energy is not negative
                                if (totalEnergy < 0) { totalEnergy = 0; }
                            }

                            break;

                        default:
                            Program.centerPara("INVALID INPUT");
                            break;


                    }

                    if(Program.player1.health <= 0)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Program.centerPara("YOU DIED");
                                Program.centerPara("☠☠☠☠☠");
                                String ans = Program.centerInput("Do you wish to restart the game? [Y or N]: ");
                                if (ans.ToUpper() == "Y")
                                {
                                    Console.Clear();
                                    Program.player1.resetAttributes();  
                                    Program.start();
                                }
                                else if (ans.ToUpper() == "N")
                                {
                                    Console.WriteLine();
                                    Program.centerPara("Thank You For Playing.");
                                    Console.WriteLine();
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Program.centerPara("INVALID INPUT");
                                    Console.Clear();
                                }
                            }
                            catch (Exception e)
                            {
                                Program.centerPara("INVALID INPUT");
                            }
                        }
                    }
                } catch(Exception e) {Program.centerPara("INVALID INPUT"); }

                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("\n");
            Program.centerPara("You have successfully beaten " + enemyName + "!");
            Console.ReadKey();
            Console.Clear();
        }


        public static void recieveWeapon(String weaponName)
        {
            Program.centerPara("\nITEM AQUIRED: " + weaponName);
            Program.centerPara("-----------------------------------");
            Program.centerPara("| Damage: " + Program.player1.weaponValue + "                       |");
            Program.centerPara("-----------------------------------");
        }

        public static void recieveAmulet(String amuletName)
        {
            Program.centerPara("\nITEM AQUIRED: " + amuletName);
            Program.centerPara("-----------------------------------");
            Program.centerPara("| Defense: " + Program.player1.amuletValue + "                      |");
            Program.centerPara("-----------------------------------");
        }

        public static void upgradeWeapon(String weaponName)         
        {
            Program.player1.weaponValue += 2;
            Program.centerPara("\nWEAPON UPGRADED: " + weaponName);
            Program.centerPara("-----------------------------------");
            Program.centerPara("| Damage: " + Program.player1.weaponValue + "                       |");
            Program.centerPara("-----------------------------------");
        }

        public static void upgradeAmulet(String amuletName)
        {
            Program.player1.amuletValue += 2;
            Program.centerPara("\nAMULET UPGRADED: " + amuletName);
            Program.centerPara("-----------------------------------");
            Program.centerPara("| Defense: " + Program.player1.amuletValue + "                      |");
            Program.centerPara("-----------------------------------");
        }


    }
}
