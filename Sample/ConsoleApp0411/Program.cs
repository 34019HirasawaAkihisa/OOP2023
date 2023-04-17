using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {

        static int num1;
        static int num;
        public static void money() {
            for (int i = 0; i < num1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {

            Console.Write("金額:");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("支払い");
            int pay = int.Parse(Console.ReadLine());
            int change = pay - sum;
            Console.WriteLine("お釣り:" + change);
            num1 = change / 10000;num = change % 10000;
            Console.Write("一万円札:"); money();
            num1 = num / 5000; num = num % 5000;
            Console.Write("五千円札:"); money();
            num1 = num / 2000; num = num % 2000;
            Console.Write("二千円札:"); money();
            num1 = num / 1000;num = num % 1000;
            Console.Write("千円札:"); money();
            num1 = num / 500;num = num % 500;
            Console.Write("五百円:"); money();
            num1 = num / 100;num = num % 100;
            Console.Write("百円:"); money();
            num1 = num / 50;num = num % 50;
            Console.Write("五十円:"); money();
            num1 = num / 10; num = num % 10;
            Console.Write("十円:"); money();
            num1 = num / 5;num = num % 5;
            Console.Write("五円:"); money();
            num1 = num / 1;
            Console.Write("一円:"); money();
        }
    }
}
