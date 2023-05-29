using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            MainManager mainManager = new MainManager();
            string command;
            while (true)
            {
                // TODO Show a help message
                Console.WriteLine("Enter a command:");
                command = Console.ReadLine();
                switch (command)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        mainManager.AddNewPlayer();
                        break;
                        // TODO Add more cases to cover all required options    
                }
            }
        }
    }
}
