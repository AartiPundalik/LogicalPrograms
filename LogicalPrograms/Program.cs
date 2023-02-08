using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fibonacci Series");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Displayfibonacci();
                    break;

                case 2:

                    PerfectNumber checkperfectnumber= new PerfectNumber();
                    checkperfectnumber.checkperfectnumber();
                    break;

                    case 3:
                    PrimeNumber Prime = new PrimeNumber();
                    Prime.Prime();
                    break;

                case 4:
                    Reverse Display = new Reverse();
                    Display.Display();
                    break;

                    case 5:
                    CouponNumber Coupon = new CouponNumber();
                    Coupon.Coupon();
                    break;
            }
            Console.ReadLine();
        }
    }
}

        
    
