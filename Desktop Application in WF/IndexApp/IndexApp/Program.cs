using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 100, 200, 300, 400, 100 };
             int desiredValue = Array.LastIndexOf(myArray);
            //int desiredValue = Array.FindIndex(myArray, 200);


            Console.WriteLine(desiredValue);
            Console.ReadKey();

          
        }
    }
}
