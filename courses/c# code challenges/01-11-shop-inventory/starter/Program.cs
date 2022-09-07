using System;

namespace shopinventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for(int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
        }

        // MARK: Write your solution here
        public static void AddItem(int index, string name)
        {

        }

        // MARK: Write your solution here
        public static void GetAllItems()
        {

        }
    }
}