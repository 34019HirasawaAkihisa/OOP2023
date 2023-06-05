using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var cnt = text.Count(s => s == ' ');
            Console.WriteLine(cnt);
        }

        private static void Exercise3_2(string text) {
            var change = text.Replace("big", "small");
            Console.WriteLine(change);
        }

        private static void Exercise3_3(string text) {
            var word = text.Split(' ').Count();
            Console.WriteLine(word);
        }

        private static void Exercise3_4(string text) {
            var search = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var s in search) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise3_5(string text) {
            var split = text.Split(' ').ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var word in split) {
                sb.Append(word + ' ');
            }
            var ts = sb.ToString();
            Console.WriteLine(ts);
        }
    }
}
