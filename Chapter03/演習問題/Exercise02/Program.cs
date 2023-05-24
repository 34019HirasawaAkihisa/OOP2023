using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                string city = Console.ReadLine();
                if (string.IsNullOrEmpty(city)) {
                    break;
                }
                var cities = names.FindIndex(s => s == city);
                Console.WriteLine(cities);
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Where(s => s.Contains('o')).Count();
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var find = names.Where(s => s.Contains('o')).ToList();
            foreach(var n in find) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var select = names.Where(s => s[0] == 'B').Select(s => s.Length);
            foreach (var n in select) {
                Console.WriteLine(n);
            }
        }
    }
}
