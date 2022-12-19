using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var duckfarm1 = DuckFarm.Get();
            var duckfarm2 = DuckFarm.Get();
            var duckfarm3 = DuckFarm.Get();
            var duckfarm4 = DuckFarm.Get();

            var farmList1 = new List<DuckFarm>() { duckfarm1, duckfarm2 };
            var farmList2 = new List<DuckFarm>() { duckfarm3, duckfarm4 };

            bool Equal = Enumerable.SequenceEqual(farmList1, farmList2);

            Console.WriteLine(Equal);

            Console.ReadKey();
        }
    }
}