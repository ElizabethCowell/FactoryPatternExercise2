using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool badImput = false;
            string response = "";
            do
            {
                Console.WriteLine("What Database would you like to use? \n" +
                    "SQL \n" +
                    "Mongo \n" +
                    "List");
                response = Console.ReadLine();
                if(response != "sql" && response != "mongo" && response != "list")
                {
                    badImput = true;
                }
            } while (badImput == true);
            var type = DataAccessFactory.GetDataAccessType(response);

            var products = type.LoadData();
            foreach (var product in products)
            {
                Console.WriteLine($"Name:{product.Name}");
                Console.WriteLine($"Price:{product.Price}");
            }
            type.SaveData();
        }
    }
}
