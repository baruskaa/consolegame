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
            //contains entire game
            welcome();
            intro();
            Encounters.encounterLouise();
        }

        static void welcome()
        {

            Console.WriteLine();
            centerPara(".-=~=-.                                               .-=~=-.");
            centerPara("(__  _)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(__  _)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(__  _)                                               (__  _)");
            centerPara("(_ ___)                   TITLE HERE                  (_ ___)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(__  _)           Press Any Key to Continue...        (__  _)");
            centerPara("(_ ___)                                               (_ ___)");
            centerPara("( _ __)                                               ( _ __)");
            centerPara("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___)");
            centerPara("`-._.-'                                               `-._.-'");
            Console.ReadKey();
            Console.Clear();    
        }

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

            Console.WriteLine();
            centerPara("Before we begin your journey, may I ask your name?");
            player1.name = centerInput("");
            Console.WriteLine();

            centerPara("Ah, " + player1.name + ", It’s good to meet you. Let’s begin, shall we?  >>>");
            Console.ReadKey();
            Console.Clear();
        }


        
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
