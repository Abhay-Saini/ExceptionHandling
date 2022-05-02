using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Throw
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please entre the first digit");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please entre the second digit");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre the operation you want to perform 1. + 2. - 3. * 4. / 5. %");

            string s = Console.ReadLine();

            if(s == "+")
                Console.WriteLine("The result is {0} ", a + b);
            else if(s=="-")
                  Console.WriteLine("The result is {0} ", a - b);
            else if (s == "*")
                Console.WriteLine("The result is {0} ", a * b);
            else if (s == "/")
            {
                try
                {
                    Console.WriteLine("The result is {0} ", a / b);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Please entre valid digit");
                }
            }
               
            else if (s == "%")
                Console.WriteLine("The result is {0} ", a % b);
            else
                 
                Console.WriteLine("The result not is {0} ");


            Console.ReadLine();

        }
    }
}
