
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRE THE NUMBERS");

          

            try
            {

                int a = int.Parse(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());


                int c = a / b;

                Console.WriteLine("The result is  {0} ", c);


                //Console.WriteLine("Thanks for using me");

            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("Your input is invalid{0} ", Ex);

                //Console.WriteLine("Thanks for using me");
            }


            catch (FormatException Ex)
            {
                Console.WriteLine("Your input is invalid" + Ex);

                // Console.WriteLine("Thanks for using me");
            }

            catch (Exception Ex)
            {
                Console.WriteLine("Your input is invalid");

                //Console.WriteLine("Thanks for using me");
            }
            finally          // use to print deafult message 
            {

                Console.WriteLine("Thanks for using me");
            }

        


            Console.ReadLine();


                
            

        }
    }
}
