using static System.Net.Mime.MediaTypeNames;

namespace GameTest
{
    internal class Program
    {

        public static Player player1 = new Player();
        static void Main(string[] args)
        {
            start();
        }


        public static void start()
        {
            welcome();
            intro();
            Encounters.encounterLouise();
            Encounters.encounterForest();
            Encounters.encounterFinal();
        }

        static void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            centerPara(".-=~=-.                                               .-=~=-.");
            centerPara("(__  _)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(__  _)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(__  _)                                               (__  _)");
            centerPara("(_ ___)              ECHOES OF MARNABERIA             (_ ___)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(__  _)           Press Any Key to Continue...        (__  _)");
            centerPara("(_ ___)                                               (_ ___)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___)");
            centerPara("`-._.-'                                               `-._.-'");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        //ROSAL + LABAYNO 

        static void intro()
        {
            Console.WriteLine();
            centerPara("The woodland is quiet.");
            centerPara("Sunlight pours through the leaves, leaving comforting shadows on the ground");
            centerPara("as you strike your axe into the solid trunk of an oak tree. >>>");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            centerPara("You are a woodcutter having a humble and content forest-dwelling life.");
            centerPara("However, the universe has other plans for you today.  >>>");
            Console.ReadKey();
            Console.Clear();

            string playerName = "";

            while (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine();
                centerPara("Before we begin your journey, may I ask your name?");
                Console.WriteLine();

                playerName = centerInput("[ Enter Your Name ]");

                if (string.IsNullOrWhiteSpace(playerName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    centerPara("Name cannot be empty. Please enter a valid name.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ResetColor();
                }
            }

            player1.name = playerName;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            centerPara("Ah, " + player1.name + ", It’s good to meet you. Let’s begin, shall we?  >>>");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        //ROSAL + LABAYNO 



        public static void centerPara(String text)
        {
            int windowWidth = Console.WindowWidth;
            int textPosition = (windowWidth - text.Length) / 2;
            Console.SetCursorPosition(textPosition, Console.CursorTop);
            Console.WriteLine(text);
        }
        public static string centerInput(string text)
        {
            int windowWidth = Console.WindowWidth;
            centerPara(text);

            int textPosition = (windowWidth - text.Length) / 2;
            if (textPosition > 0)
                Console.SetCursorPosition(textPosition, Console.CursorTop);

            string userInput = Console.ReadLine();
            return userInput.ToUpper();
        }

    }
}
