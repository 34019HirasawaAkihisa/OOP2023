using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var PrefectureDict = new Dictionary<string, string>() {
            };

            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");
            string prefecture = Console.ReadLine();

            while (prefecture != "999") {
                Console.Write("所在地;");
                string Pc = Console.ReadLine();

                if (PrefectureDict.ContainsKey(prefecture)) {
                    Console.Write("上書きしますか？(y/n):");
                    string judge = Console.ReadLine();

                    if (judge == "ｙ") {
                        PrefectureDict[prefecture] = Pc;
                    }
                }
                else {
                    PrefectureDict.Add(prefecture, Pc);
                }

                Console.Write("県名:");
                prefecture = Console.ReadLine();
            }

            Console.WriteLine("1:一覧表,2:県名指定");
            Console.Write(">");
            string num = Console.ReadLine();
            if (num == "1") {
                foreach (var s in PrefectureDict) {
                    Console.WriteLine("{0}({1})",s.Key,s.Value);
                }
            }
            else {
                Console.Write("県名を入力:");
                string pre = Console.ReadLine();
                Console.WriteLine(PrefectureDict[pre]);
            }
        }
    }
}
