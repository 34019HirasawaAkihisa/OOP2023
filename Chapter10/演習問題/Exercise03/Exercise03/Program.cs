using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };
            foreach (var match in texts) {
                var matches = Regex.Matches(match, @"\b(T|t)ime\b");
                foreach (Match s in matches) {
                    Console.WriteLine("{0}:{1}", match, s.Index);
                }
            }
        }
    }
}
