using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prime_no_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;

            //Input: Number
            Console.WriteLine("Enter the number you want to check:");
            int num = Convert.ToInt32(Console.ReadLine());

            //Initialization
            int i = 2;

            //Condition
            while (i < Math.Sqrt(num))
            {
                //To check whether the number is prime or not
                if (num % i == 0) 
                {
                    isPrime = true;
                    
                }
                else
                {
                    isPrime = false;
                    
                }

                //Incrementation
                i++;
            }

            //Output
            if (isPrime) 
            {
                Console.WriteLine("{0} is a prime number.", num);
            }
            else
            {
                Console.WriteLine("{0} is a composite number.",num);
            }

        }
    }
}
