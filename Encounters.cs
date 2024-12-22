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

            //ROSAL + LABAYNO 

            Console.WriteLine();
            Program.centerPara("Suddenly, a high-pitched scream echoes through the trees,");
            Program.centerPara("cutting through the peaceful atmosphere like a knife. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  ???: AAAAAAHHHHHH!!!!!!                                     ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("You freeze, gripping your axe tighter.");
            Program.centerPara("That scream… It’s coming from deeper in the forest.");
            Console.WriteLine();
            Program.centerPara("It’s desperate, terrified.");
            Console.WriteLine();
            Program.centerPara("Someone’s in trouble. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  ???: HELP!!! PLEASE, SOMEONE!!!!                            ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.WriteLine();
            Program.centerPara("As you approach the area, you see her——a woman sprinting as fast");
            Program.centerPara("as her legs can carry her, a terrified expression on her face.");
            Console.WriteLine();
            Program.centerPara("And behind her... >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Program.centerPara("A gigantic beast, twisted and inhumane, is drawing near upon her.");
            Program.centerPara("Its massive claws cutting through the underbrush. She’s moments");
            Program.centerPara("away from being caught. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("You have no weapon but your axe--an ordinary woodcutter’s tool.");
            Console.WriteLine();
            Program.centerPara("But it’s enough.");
            Console.WriteLine();
            Program.centerPara("It has to be. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            combat("Monstrous Beast", 10, 60);

            Console.WriteLine();
            Program.centerPara("The woman was stunned in silence as you fought with nothing but your");
            Program.centerPara("axe. The sound of metal filled the air as it struck the thick skin");
            Program.centerPara("of the beast. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("The monstrous creature lets out a final, deep growl before becoming lifeless.");
            Console.WriteLine();
            Program.centerPara("You won the tough battle, nevertheless. When the dust settles, you");
            Program.centerPara("turned to the woman you just saved. She steps closer, her eyes");
            Program.centerPara("scanning the scene. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ": Are you alr——                                             ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  ???: Let's check the body. We need to find that amulet.     ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ": Amulet? What amulet?                               ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("With caution, you both get closer to the enormous beast's body,");
            Program.centerPara("its twisted limbs spread out across the woodland floor. Something");
            Program.centerPara("glistens by its neck when you crouch next to it.");
            Console.WriteLine();
            Program.centerPara("Reaching down, you take it and hold it up to look at it closer. ");
            Program.centerPara("It's a finely carved jewel encased in a golden disk.");
            Program.centerPara("It glows a soft, ethereal light. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ": You mean this?                                     ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  ???: Yes. Every beast that lives in this forest acquires a  ");
            Program.centerPara("       a special item that helps them survive. This one       ");
            Program.centerPara("       pecifically carriesm a Montradaine Amulet that greatly ");
            Program.centerPara("       enhances defense. You should take it—-it can help you  ");
            Program.centerPara("       in your fight.                                         ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ": Fight? What fight? tell me, who are you? And   ");
            Program.centerPara("                   why was that creature chasing you?             ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Louivistra: My name is Louivistra. My sister, Princess,     ");
            Program.centerPara("              Nicoria has been taken by Svyrinia and Caityss, ");
            Program.centerPara("              the two-headed monster that rules these lands.  ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Louivistra: That creature was one of their servants.        ");
            Program.centerPara("              Please help me save her. You’re the             ");
            Program.centerPara("              only one who can.                               ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ":  I don’t know... I don’t think I’m strong      ");
            Program.centerPara("                   enough to take on something so powerful...     ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Louivistra: Please, I’m begging you. You’re the only one    ");
            Program.centerPara("              who can save her. Our kingdom is thousands of   ");
            Program.centerPara("              miles away, and if we don’t act quickly, the    ");
            Program.centerPara("              he two-headed monster might harm my sister.     ");
            Program.centerPara("                                                              ");
            Program.centerPara("              I can’t do this alone.                          ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("She looks at you desperately. You try to weigh out the gravity");
            Program.centerPara("of her words, the weight of the amulet still heavy in your hand.");
            Program.centerPara("Your heart races as you feel the dangers ahead.");
            Console.WriteLine();
            Program.centerPara("With a deep sigh, you arch your shoulders and meet Louivistra's");
            Program.centerPara("eyes, determination fueling within you.   >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara(" " + Program.player1.name + ":  Alright. I'll do it. But I don't think my      ");
            Program.centerPara("                   axe will be enough to defeat such powerful      ");
            Program.centerPara("                   creatures as Svyrinia and Caityss...            ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.WriteLine();
            Program.centerPara("She runs to a bush and rummaged through it. From there, she");
            Program.centerPara("pulls out a majestic-looking sword. Even from far away, you're");
            Program.centerPara("able to clearly see its shiny, ornate handle that connects to a");
            Program.centerPara("glistening, sharp blade. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Louivistra: Take this. This is the \"Soul Reaver\". Its a   ");
            Program.centerPara("              sword that has been passed down in our family   ");
            Program.centerPara("              for thousands of generations. It's the only     ");
            Program.centerPara("              weapon in this world powerful enough to harm    ");
            Program.centerPara("              the wicked Svyrinia and Caityss.                ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("She hands the sword to you. Its blade almost as wide as your");
            Program.centerPara("palm. You give it a few swings as you try to get used to its");
            Program.centerPara("weight.");
            Console.WriteLine();
            Program.centerPara("She also hands you a map that leads to Marnaberia, where the");
            Program.centerPara("castle of Svyrinia and Caityss is located. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Louivistra: Take care and good luck on your journey,        ");
            Program.centerPara("              " + Program.player1.name + ". I'm convinced you hold the strength   ");
            Program.centerPara("              to finally bring an end to the terror of        ");
            Program.centerPara("              Svyrinia and Caityss.                           ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("Feeling a wave of courage washed over you, you nod.");
            Program.centerPara("The forest grows ahead, a twisted labyrinth of darkness");
            Program.centerPara("and mystery, yet you march on with a mission.  >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            recieveWeapon("Soul Reaver", 50);
            Console.WriteLine();
            recieveAmulet("Montradaine Amulet", 25);
            Console.ReadKey();
            Console.Clear();
        }
        public static void encounterForest()
        {
            Console.WriteLine();
            Program.centerPara("You take on the journey through the lush forest of Naresia,");
            Program.centerPara("where huge trees stretch high above, their massive trunks");
            Program.centerPara("covered in vivid green moss.");
            Console.WriteLine();
            Program.centerPara("The high tree canopy above produces shadows that move across");
            Program.centerPara("the forest floor, making it difficult to see the steps ahead. >>>");
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Program.centerPara("The pathway suddenly divides into two separate routes.");
                    Console.WriteLine();
                    Program.centerPara("While the road on the left appears hazardous and silent,");
                    Program.centerPara("the other is darker and vibrates with the noises");
                    Program.centerPara("distant conflicts.>>>");
                    Console.WriteLine();
                    Program.centerPara("Every route has unique risks and benefits. Left or Right?");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.centerPara("Select carefully, " + Program.player1.name + ". Your future could");
                    Program.centerPara("be altered by the path you choose to take.");
                    Console.WriteLine();
                    String path = Program.centerInput("[ L or R ]");
                    Console.ResetColor();

                    //ROSAL + LABAYNO 

                    switch (path)
                    {
                        case "L":
                            Console.Clear();
                            encounterForestLeft();
                            break;

                        case "R":
                            Console.Clear();
                            encounterForestRight();
                            break;
                        default:
                            Program.centerPara("INVALID INPUT");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                    if (path == "L" || path == "R")
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Program.centerPara("INVALID INPUT");
                }
            }

            Console.WriteLine();
            Program.centerPara("With your battles complete, you spend the night at an abandoned hut.");
            Program.centerPara("The strength and materials you’ve gained will aid you on your");
            Program.centerPara("quest to rescue Princess Nicoria.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Program.centerPara("Having enough supplies gathered from foraging and battle, you brew");
            Program.centerPara("some potions for a moment. You’ll need every advantage in");
            Program.centerPara("the trials to come tomorrow >>>.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            recieveItem("Health Potions", "Health Regeneration");
            Program.player1.potionCount = 10;
            Console.ReadKey();
            Console.Clear();
        }
        public static void encounterForestLeft()
        {
            Console.WriteLine();
            Program.centerPara("You decide to take the left route where there is an");
            Program.centerPara("unsettling silence and a heavy, quiet air.");
            Console.WriteLine();
            Program.centerPara("The absence of any sound makes your footsteps seem louder,");
            Program.centerPara("echoing unnaturally through the trees. The trees seem to");
            Program.centerPara("close in tighter as you move forward, their twisted branches");
            Program.centerPara("casting eerie shadows. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("After a few minutes of walking, you find yourself facing a");
            Program.centerPara("lone creature that has made this part of the forest its home:");
            Console.WriteLine();
            Program.centerPara("a Naresian Orc. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Program.centerPara("The orc notices your prescence. Another battle begins as");
            Program.centerPara("the orc approaches with heavy, lumbering strikes. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Program.player1.resetHNE();
            combat("Naresian Orc", 33, 120);
            Program.player1.resetHNE();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("Upon defeating the Naresian Orc, it collapses with a roar,");
            Program.centerPara("leaving behind a handful of Auris rocks, known for their");
            Program.centerPara("unique regenerative properties.");
            Console.ResetColor();
            Console.WriteLine();
            Program.centerPara("These stones, shimmering with a soft golden light, are said");
            Program.centerPara("to hold the very essence of the earth, capable of improving");
            Program.centerPara("leaving behind a handful of Auris rocks, known for their");
            Program.centerPara("both energy and health to those who possess them.");
            Console.WriteLine();
            Program.centerPara("You pick it all up. These might be useful later. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.WriteLine();
            recieveItem("Auris Rocks", "Health & Energy Regeneration");
            Console.ReadKey();
            Console.Clear();
        }
        public static void encounterForestRight()
        {
            Console.WriteLine();
            Program.centerPara("You decide for the right path, drawn by the sounds of ");
            Program.centerPara("conflict. Tension and the sound of screams and clashing");
            Program.centerPara("steel fills the air.");
            Console.WriteLine();
            Program.centerPara("You try to hide your prescence to avoid getting detected.");
            Program.centerPara("Shadows stretch unnervingly along the ground, and the feeling");
            Program.centerPara("of being watched lingers with every step. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("You hear an ominous laugh from a distance. It’s a well known");
            Program.centerPara("warning sign that you’ve come across their territory–-Iphema Bandits.");
            Console.WriteLine();
            Program.centerPara("Stealthy and criminals who thrive in the darkness of the");
            Program.centerPara("forest. They strike quickly, holding twin daggers while");
            Program.centerPara("donning treasures they’ve stolen from their victims. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Program.centerPara("Suddenly, a bandit leaps from the shadows, their daggers");
            Program.centerPara("gleaming as they slice through the air, and the battle");
            Program.centerPara("begins with a violent clash as you struggle to fend off");
            Program.centerPara("their fierce assault. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();


            Program.player1.resetHNE();
            combat("Iphema Bandit", 35, 100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("After a tense battle, you manage to overpower the");
            Program.centerPara("Shadow Bandit. They drop some Solaris Leaves as you");
            Program.centerPara("as you catch your breath.");
            Console.ResetColor();
            Console.WriteLine();
            Program.centerPara("You've read about this plant. It's a rare ingredient");
            Program.centerPara("that’s used for revitalization potions. Solaris Leaves");
            Program.centerPara("are said to harness the energy of the sun, capable");
            Program.centerPara("of restoring vitality in a matter of seconds.");
            Console.WriteLine();
            Program.centerPara("You pick it all up. These might be useful later. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            recieveItem("Solaris Leaves", "Energy Restoration");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("As you continue on the trail, the distant screams");
            Program.centerPara("of battle fade into an eerie silence, leaving only the");
            Program.centerPara("oppressive weight of the forest's gloom. You come");
            Program.centerPara("upon the Mneophy--a creature of nightmares. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("Its body is a bizarre mix of muscle and twisted");
            Program.centerPara("bone, with sharp patches of rough black fur.");
            Program.centerPara("Its piercing blue eyes sparkle unnaturally, as if");
            Program.centerPara("illuminated from within, locking onto you with a");
            Program.centerPara("look that seems to penetrate deep into your soul. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Program.centerPara("The Mneophye's massive claws dig into the earth,");
            Program.centerPara("and its powerful frame coils like a spring, ready to");
            Program.centerPara("unleash its deadly force in an instant.");
            Console.WriteLine();
            Program.centerPara("A deep, rumbling snarl escapes its throat as it");
            Program.centerPara("prepares to strike with terrifying speed. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Program.player1.resetHNE();
            combat("Mneophye", 35, 150);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("Defeating such a mystic beast fills you with newfound");
            Program.centerPara("power, and it drops a Vividus Gem and a handful");
            Program.centerPara("of its enchanted fur.");
            Console.ResetColor();
            Console.WriteLine();
            Program.centerPara("You’ve heard of these items in widespread tales.");
            Program.centerPara("The Vividus Gem is a rare crystal, known to be");
            Program.centerPara("infused with active regenerative witchcraft, while");
            Program.centerPara("the Mneophye's fur contains the creature’s own");
            Program.centerPara("essence, used in crafting strength-enhancing elixirs.");
            Console.WriteLine();
            Program.centerPara("You pick these up. These might be useful later. >>>");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.WriteLine();
            recieveItem("Vividus Gem", "Power Regeneration");
            Console.WriteLine();
            recieveItem("Mneophye's Fur", "Strength Enhancer");
            Console.ReadKey();
            Console.Clear();
        }

        public static void encounterFinal()
        {
            Console.WriteLine();
            Program.centerPara("The forests parted to show a magnificent castle with black");
            Program.centerPara("spikes piercing the sky. As you approach, you feel a sense ");
            Program.centerPara("of darkness.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Program.centerPara("You’ve arrived at the castle where Nicoria is held. But your");
            Program.centerPara("journey is far from over. Before you, Marnaberian Soldiers of the");
            Program.centerPara("castle march forward, dark magic swirling around them.");
            Program.centerPara("They will not let you pass easily. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Program.player1.resetHNE();
            combat("Marnaberian Soldier 1", 30, 80);
            combat("Marnaberian Soldier 2", 30, 80);
            combat("Marnaberian Soldier 3", 32, 80);
            combat("Marnaberian Soldier 4", 32, 80);
            combat("Marnaberian Soldier 5", 33, 80);

            Console.WriteLine();
            Program.centerPara("You go farther within the castle after taking out the guards.");
            Program.centerPara("You enter a large hall that is strangely silent.");
            Program.centerPara("Your gaze is drawn to a grand, elaborate portrait.");
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.WriteLine();
            Program.centerPara("Strange… the painting on the wall shows two royal figures,");
            Program.centerPara("seemingly human. They look gentle, even noble.");
            Program.centerPara("Could this be Svyrinia and Caityss before their transformation? >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("A deep growl echoes through the walls, shaking the very ");
            Program.centerPara("foundation beneath your feet. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Program.centerPara("You forcefully open the heavy doors leading to the throne chamber.");
            Program.centerPara("Svyrinia and Caityss are standing tall over you, their two heads");
            Program.centerPara("glaring with wrath. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("The ground trembles as they move toward you, their presence");
            Program.centerPara("a looming storm of fury. A chilling roar envelops the room,");
            Program.centerPara("broken only by the sound of your racing heart, as you realize");
            Program.centerPara("that every choice you make from this moment forward could");
            Program.centerPara("determine your fate. >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Program.player1.resetHNE();
            Program.player1.weaponValue += 3;
            Program.player1.amuletValue += 3;
            combat("Svyrinia and Caityss", 50, 300);

            Console.WriteLine();
            Program.centerPara("With one final strike, Svenskira and Caityss collapse.");
            Program.centerPara("As they fall, their monstrous forms flicker, revealing the");
            Program.centerPara("tormented souls trapped within, their anguished cries");
            Program.centerPara("echoing in the air as darkness envelops the chamber,");
            Program.centerPara("leaving only silence in their wake. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Program.centerPara("The curse has been lifted. Svyrinia and Caityss were ");
            Program.centerPara("once royal siblings, sworn to protect the land. But their ");
            Program.centerPara("thirst for power, combined with dark magic, twisted their");
            Program.centerPara("souls into the two-headed beast that terrorized the realm. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Program.centerPara("╔════════════════════════════════════════════════════════════╗");
            Program.centerPara("                                                              ");
            Program.centerPara("  Nicoria: Thank you… You have saved me, " + Program.player1.name + ".       ");
            Program.centerPara("           Without your courage, I would still be a prisoner  ");
            Program.centerPara("           to their dark magic.                               ");
            Program.centerPara("                                                              ");
            Program.centerPara("╚════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //ROSAL + LABAYNO 

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("And so, with the curse broken and the princess saved,");
            Program.centerPara("your journey comes to an end. The monsters have fallen,");
            Program.centerPara("and peace has returned to the land.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara(".-=~=-.                                               .-=~=-.");
            Program.centerPara("(__  _)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(__  _)");
            Program.centerPara("( _ __)                                               ( _ __)");
            Program.centerPara("(__  _)                                               (__  _)");
            Program.centerPara("(_ ___)             THANK YOU FOR PLAYING!            (_ ___)");
            Program.centerPara("( _ __)                                               ( _ __)");
            Program.centerPara("(__  _)                     Made by:                  (__  _)");
            Program.centerPara("(_ ___)           Svenska Rosal & Kate Labayno        (_ ___)");
            Program.centerPara("( _ __)                                               ( _ __)");
            Program.centerPara("( _ __)                                               ( _ __)");
            Program.centerPara("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___)");
            Program.centerPara("`-._.-'                                               `-._.-'");
            Console.ResetColor();
            Console.ReadKey();
            Environment.Exit(0);

        }

        // Events
        public static void combat(String name, int power, int health)
        {
            String enemyName = "";
            int enemyPower = 0;
            int enemyHealth = 0;

            int totalEnergy = Program.player1.energy;
            int totalAttack = rand.Next(5, Program.player1.weaponValue);

            enemyName = name;
            enemyPower = power;
            enemyHealth = health;

            //ROSAL + LABAYNO 


            while (enemyHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Program.centerPara("ENEMY NAME: " + enemyName);
                Program.centerPara("ENEMY POWER: " + enemyPower);
                Program.centerPara("ENEMY HEALTH: " + enemyHealth);
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.centerPara("oo=============================oo");
                Program.centerPara("||    (A)ttack     (D)efend    ||");
                Program.centerPara("||    (R)un        (H)eal      ||");
                Program.centerPara("oo=============================oo");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Program.centerPara("HEALTH: " + Program.player1.health);
                Program.centerPara("ENERGY: " + totalEnergy);
                Program.centerPara("POTIONS: " + Program.player1.potionCount);
                Console.ResetColor();
                Console.WriteLine("\n");
                try
                {
                    if (totalEnergy <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.centerPara("You ran out of energy to fight. Your attacks will deal less damage now.");
                        Console.ResetColor();
                        totalAttack -= 10;
                        if (totalAttack < 0) { totalAttack = 0; }
                        Console.WriteLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string input = Program.centerInput("What would you do?");
                    Console.WriteLine();
                    int damage = enemyPower - Program.player1.amuletValue;
                    int energy, attack;

                    switch (input)
                    {
                        case "A":
                            //atk
                            if (damage < 0) { damage = 0; }
                            attack = totalAttack + rand.Next(10, 20);
                            energy = 5;

                            Program.centerPara("You attacked " + enemyName + ".");
                            Program.centerPara("You lose " + damage + " health, " + energy + " energy, and deal " + attack + " damage.");

                            Program.player1.health -= damage;
                            enemyHealth -= attack;
                            totalEnergy -= energy;
                            if (totalEnergy < 0) { totalEnergy = 0; }

                            break;

                        //ROSAL + LABAYNO 

                        case "D":

                            //def

                            damage = (enemyPower / 4) - Program.player1.amuletValue;
                            if (damage < 0) { damage = 0; }
                            attack = totalAttack;
                            energy = 3;

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
                                energy = 3;
                                Program.centerPara(enemyName + " catches up and attacks you.");
                                Program.centerPara("You lose " + damage + " health and " + energy + " energy");
                                Program.player1.health -= damage;
                                totalEnergy -= energy;
                                if (totalEnergy < 0) { totalEnergy = 0; }
                            }
                            else
                            {
                                //success , add energy
                                energy = 4;
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
                                int potionValue = 15;
                                energy = 10;

                                Program.centerPara("You drink a potion and gain " + energy + " energy and " + potionValue + " health.");
                                Program.player1.health += potionValue;
                                totalEnergy += energy;

                                Program.player1.potionCount--;
                                if (totalEnergy < 0) { totalEnergy = 0; }
                            }

                            break;

                        default:
                            Program.centerPara("INVALID INPUT");
                            break;

                            //ROSAL + LABAYNO 
                    }

                    Console.ResetColor();


                    if (Program.player1.health <= 0)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n");
                                Program.centerPara(@"__     __   ______   ___  ___    _____   _________  ______  _____   ");
                                Program.centerPara(@"\ \   / /  / ____ \  | |  | |   | ___ \  |__   __| | ____ | | ___ \ ");
                                Program.centerPara(@" \ \_/ /   | |  | |  | |  | |   | |  | |    | |    | |___   | |  | |");
                                Program.centerPara(@"  \   /    | |  | |  | |  | |   | |  | |    | |    | ____|  | |  | |");
                                Program.centerPara(@"   | |     | |__| |  | |__| |   | |__| | ___| |___ | |____  | |__| |");
                                Program.centerPara(@"   |_|     \______/  \______/   |_____/  |_______| |______| |_____/ ");
                                Console.WriteLine("\n");
                                String ans = Program.centerInput("Do you wish to restart the game? [Y or N]: ");
                                Console.ResetColor();

                                if (ans.ToUpper() == "Y")
                                {
                                    Console.Clear();
                                    Program.player1.resetAttributes();
                                    Program.start();
                                }
                                else if (ans.ToUpper() == "N")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine();
                                    Program.centerPara(".-=~=-.                                               .-=~=-.");
                                    Program.centerPara("(__  _)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(__  _)");
                                    Program.centerPara("( _ __)                                               ( _ __)");
                                    Program.centerPara("(__  _)                                               (__  _)");
                                    Program.centerPara("(_ ___)             THANK YOU FOR PLAYING!            (_ ___)");
                                    Program.centerPara("( _ __)                                               ( _ __)");
                                    Program.centerPara("(__  _)                     Made by:                  (__  _)");
                                    Program.centerPara("(_ ___)           Svenska Rosal & Kate Labayno        (_ ___)");
                                    Program.centerPara("( _ __)                                               ( _ __)");
                                    Program.centerPara("( _ __)                                               ( _ __)");
                                    Program.centerPara("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___)");
                                    Program.centerPara("`-._.-'                                               `-._.-'");
                                    Console.ResetColor();
                                    Console.ReadKey();


                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Program.centerPara("INVALID INPUT");
                                    Console.Clear();
                                }

                                //ROSAL + LABAYNO 
                            }
                            catch (Exception e)
                            {
                                Program.centerPara("INVALID INPUT");
                            }
                        }
                    }
                }
                catch (Exception e) { Program.centerPara("INVALID INPUT"); }

                Console.ReadKey();
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Program.centerPara("You have successfully beaten " + enemyName + "!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }



        public static void recieveItem(String itemName, String usage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("ITEM AQUIRED: " + itemName);
            Program.centerPara("-----------------------------------");
            Program.centerPara(" Usage: " + usage);
            Program.centerPara("-----------------------------------");
            Console.ResetColor();
        }

        //ROSAL + LABAYNO 

        public static void recieveWeapon(String weaponName, int weaponVal)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("ITEM AQUIRED: " + weaponName);
            Program.centerPara("-----------------------------------");
            Program.centerPara(" Damage: " + weaponVal + "              ");
            Program.centerPara("-----------------------------------");
            Program.player1.weaponValue = weaponVal;
            Console.ResetColor();
        }

        //ROSAL + LABAYNO 

        public static void recieveAmulet(String amuletName, int amuletVal)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Program.centerPara("ITEM AQUIRED: " + amuletName);
            Program.centerPara("-----------------------------------");
            Program.centerPara(" Defense: " + amuletVal + "            ");
            Program.centerPara("-----------------------------------");
            Program.player1.amuletValue = amuletVal;
            Console.ResetColor();
        }
    }
}