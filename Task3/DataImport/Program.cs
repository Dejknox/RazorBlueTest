using System;
using System.IO;
using System.Linq;

namespace DataImport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines("..//..//..//TechnicalTestData.csv").Select(x => x.Split(","));

            var petrolTypes = data.OrderBy(x => x[4]).Select(x => x[4] == "Petrol");
            File.WriteAllText("..//..//..//Petrol.csv", petrolTypes.ToString());

            var electricTypes = data.Select(x => x[4] == "Electric");
            File.WriteAllText("..//..//..//Electric.csv", electricTypes.ToString());

            var dieselTypes = data.Select(x => x[4] == "Diesel");
            File.WriteAllText("..//..//..//Diesel.csv", dieselTypes.ToString());            
        }
    }
}
