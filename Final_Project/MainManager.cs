using System;
using System.Collections.Generic;

namespace Final_Project
{

    public class MainManager
    {
        private List<Player> playerList = new List<Player>();
        private List<Coach> coacheList = new List<Coach>();
        private List<Employee> employeeList = new List<Employee>();

        public MainManager()
        {
            // TODO Load members data from files we saved in previous runs
        }

        public void AddNewPlayer()
        {
            // Get a new player info from user
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter national code:");
            string nationalCode = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter goals:");
            int gaols = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter contract value:");
            int contractValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            string position = Console.ReadLine();

            // Create an instance of player based on entered data by the user
            Player player = new Player(name, nationalCode, age, number, gaols, contractValue, position);

            // Add new player to player list
            playerList.Add(player);
        }

        public void SearchByName(string name)
        {
            foreach (Player player in playerList)
            {
                if (player.GetName() == name)
                {
                    // TODO: print all player data
                }
            }

            // TODO: Do the same thing for coaches and employees
        }

        public void LoadDataFromFile()
        {
            // TODO: Read all members data from the files we saved in previous runs
        }
    }
}
