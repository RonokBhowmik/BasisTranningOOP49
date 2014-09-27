using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a long integer as input:");
            long Longint = Console.Read();
            int myConvertedInt =(Int32)Longint;
            Console.WriteLine("Converted integer Is:"+myConvertedInt);
            Console.ReadKey();
        }
    }
}
