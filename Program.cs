using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Factorial
{
    class Program
    {
        static void Main(string[] args)
        { 
           Console.WriteLine("x Factorial = Y, please enter x?");  
            int a = Convert.ToInt32(Console.ReadLine());  
            int fakt(int n)        //creating a new recursion methodology
            {
                if (n == 1)
                {
                    return 1;             
                }
                else return n * fakt(n - 1);    //The result of multiplying by 
                                                //the previous number is always returned    
            }
            Console.WriteLine("Result= " + fakt(a));    //Print the result 
            Console.ReadLine();

        }
    }
}
