using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        public int Fib(int n) {
            if (n == 2 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        public int[] PrimeFactors(int n) {
            ArrayList primes = new ArrayList();
            int div = 2;
            while (div <= n) {
                if (IsPrime(div))
                {
                    if (n % div == 0)
                    {
                        primes.Add(div);
                    }
                }
                div++;
            }
            int[] solution = (int[])primes.ToArray(typeof(int));
            return solution;
         }

        

        public bool IsPrime(int n) {
            int div = 2;
            while (div <= Math.Sqrt(n)) {
                if (n % div == 0) {
                    return false;
                }
                div++;
            }
            return true;

        }

        public int[] ChangeReturn(int cents) {

            int quarters = cents / 25;
            cents = cents - quarters * 25;
            int dimes = cents / 10;
            cents = cents - dimes * 10;
            int nickels = cents / 5;
            cents = cents - nickels * 5;
            int pennies = cents;
            int[] change = new int[] { quarters, dimes, nickels, pennies };
            return change;
        }

        public void PrintChange(int[] change) {
            Console.WriteLine("Quarters: {0}, Dimes: {1}, Nickels: {2}, Pennies: {3}", change[0], change[1], change[2], change[3]);
        }

        public bool[] CoinFlip(int n) {
            bool[] flips = new bool[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                flips[i] = rand.Next(0, 2) == 0;
            }
            return flips;
        }
        static void Main(string[] args)
        {

            Numbers num = new Numbers();
            Console.WriteLine(num.Fib(10));
            Console.WriteLine(num.IsPrime(14));
            Console.WriteLine(num.IsPrime(13));
            var primes = num.PrimeFactors(14);
            foreach (int p in primes) {
                Console.WriteLine("{0},", p);
            }

            int[] change = num.ChangeReturn(65);
            num.PrintChange(change);

            var flips = num.CoinFlip(14);
            foreach (bool f in flips)
            {
                Console.WriteLine("{0},", f);
            }


            Console.ReadLine();
        }
    }
}
