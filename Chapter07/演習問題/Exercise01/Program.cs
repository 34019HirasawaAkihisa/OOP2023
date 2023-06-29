using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach (var item in text) {
                var cu = char.ToUpper(item);
                if('A' <= cu && cu <= 'Z') {
                    if (dict.ContainsKey(cu)) {
                        dict[cu]++;
                    }
                    else {
                        dict[cu] = 1;
                    }
                }
            }
            foreach (var d in dict.OrderBy( s=>s.Key)) {
                Console.WriteLine("{0}:{1}", d.Key, d.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var item in text) {
                var cu = char.ToUpper(item);
                if ('A' <= cu && cu <= 'Z') {
                    if (dict.ContainsKey(cu)) {
                        dict[cu]++;
                    }
                    else {
                        dict[cu] = 1;
                    }
                }
            }
            foreach (var d in dict) {
                Console.WriteLine("{0}:{1}", d.Key, d.Value);
            }
        }
    }
}
