using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prints the sum of the numbers o to 9 using for loop
            Console.Write("Prints the sum of the numbers o to 9 using for loop: ");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            
            //Prints the sum of the numbers o to 9 using while loop
            Console.Write("Prints the sum of the numbers o to 9 using while loop:");
            int a = 0;
            int sum1 = 0;
            while (a <9)
            {
                a++;
                sum1 = sum1 + a;
                
            }
            Console.WriteLine(sum1);

            //Prints the sum of the numbers o to 9 using do while loop
            Console.Write("Prints the sum of the numbers o to 9 using do while loop:");
            int b = 0;
            int sum2 = 0;
            do
            {
                b++;
                sum2 = sum2 + b;
            } while (b <9);

            Console.WriteLine(sum2);



            //Prints Computer Science Five times
            Console.WriteLine("Prints Computer Science Five times:");
            string mytext = "Computer Science";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mytext);
            }
            Console.ReadKey();
        }
    }
}
