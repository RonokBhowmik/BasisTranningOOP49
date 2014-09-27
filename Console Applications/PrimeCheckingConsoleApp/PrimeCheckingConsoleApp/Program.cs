using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheckingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number from the Keyboard:");

            int Number=Console.Read();

            //bool isPrime = true;

            //for (int i = 2; i < Number; i++)
            //{
            //    if (Number%2 == 0)
            //    {
            //       isPrime = false;
            //       break;
            //    }
            //}
            
            //if (isPrime==false)
            //{
            //    Console.WriteLine(" Not Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Prime");
            //}

            for (int i = 2; i <= Number / 2; i++)
            {
                if (Number % i != 0)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine(" Not Prime");
            }

            
            Console.ReadKey();

        }
        }
   
    }
