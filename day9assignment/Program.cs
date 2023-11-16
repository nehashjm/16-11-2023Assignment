using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> initialdata = new List<object>() { 1,2,3,"four","five"};
            using (LargeDataCollection largeData = new LargeDataCollection(initialdata))
            {
                largeData.AddElement(6);
                largeData.AddElement(7);

                Console.WriteLine("Elements in LargedataCollection");
                for (int i = 0;i<initialdata.Count;i++)
                {
                    Console.WriteLine(largeData.GetElement(i));
                }
                Console.ReadKey();
            }
        }
        

    }
}
