using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var testList = new List<int> { 1, 2, 3, 4 };
            var isOnlyEven = true;
            Console.WriteLine(testList.GetElementsString());
            Console.WriteLine(testList.ConditionalWhere(isOnlyEven,number=>number % 2 == 0));
            Console.ReadKey();
        }
        
    }



}
