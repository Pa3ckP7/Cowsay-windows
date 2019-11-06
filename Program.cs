using System;

namespace cowsay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("use command help for instructions on how to use this app");
            CommandManager cm = new CommandManager();
            bool running = true;
            while (running == true)
            {
                Console.Write("cowsay>");
                String ukaz = Console.ReadLine();
                if (!ukaz.Equals("quit"))
                {
                    cm.Sprejem(ukaz);
                }
                else
                {
                    running = false;
                }
            }
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }
    }
}
