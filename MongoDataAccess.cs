using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public static List<Products> Products = new List<Products>()
        {
            new Products(){ Name = "ipod", Price = 350.00 },
            new Products(){ Name = "skateboard", Price = 45.00 },
            new Products(){ Name = "sketchers", Price = 60.00 },
            new Products(){ Name = "Walkman", Price = 30.00 },

        };

        public List<Products> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a Mongo Data Access database");
        }
    }
}
