namespace GitCode
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till den här appen!");
            int run = 0;
            while (true)
            {
                Console.WriteLine("Välj ett heltal i menyn");
                run = int.Parse(Console.ReadLine());
                if (run == 1)
                {
                    Greetings();
                }
                else if (run == 2)
                {
                    GreetingsUser();
                }
                else 
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }

        static void Greetings()
        {
            Console.WriteLine("Hello from GitCode");

        }

        static void GreetingsUser()
        {
            Console.WriteLine("Hello from Adrian");

        }
    }
}
