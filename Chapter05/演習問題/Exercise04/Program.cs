using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

            /*
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var replaced = line.Replace("Novelist", "作家  ").Replace("=", ":").Replace("BestWork", "代表作")
                                                                             .Replace("Born", "誕生年");
            var split = replaced.Split(';');
            foreach (var s in split) {
                Console.WriteLine(s);
            }
            */

            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
            for (int i = 0; i < lines.Length; i++) {
                var replaced = lines[i].Replace("Novelist", "作家  ").Replace("=", ":").Replace("BestWork", "代表作")
                                                                                 .Replace("Born", "誕生年");
                var split = replaced.Split(';');
                foreach (var s in split) {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
