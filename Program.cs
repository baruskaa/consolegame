namespace GameTest
{
    internal class Program
    {

        public static Player player1 = new Player();
        static void Main(string[] args)
        {
                Start();
        }

        public static void Start()
        {
            //contains entire game
            Welcome();
            Intro();
            Encounters.encounterLouise();
        }

        static void Welcome()
        {
            Console.WriteLine("TITLE HERE");
            Console.WriteLine("\nPress Any Key to Continue...");
            Console.ReadKey();
            Console.Clear();    
        }

        static void Intro()
        {
            Console.Write("Enter Your Name: ");
            player1.name = Console.ReadLine();
            Console.WriteLine(player1.name + "\nINSERT NARRATION INTRO");
            // mc is chopping wood, hears louise screaming, goes to where the sound is coming from....
            Console.Clear();
        }
    }
}
