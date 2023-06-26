using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var PrefectureDict = new Dictionary<string, List<CityInfo>>() {
            };

            Console.WriteLine("都市登録");

            Console.Write("県名:");
            string prefecture = Console.ReadLine();

            while (prefecture != "999") {
                var cityinfo = new CityInfo();

                Console.Write("都市名:");
                cityinfo.City = Console.ReadLine();


                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());


                if (PrefectureDict.ContainsKey(prefecture)) {
                    //   Console.Write("既にキーが存在します。追加しますか？(y/n):");
                    //   string judge = Console.ReadLine();

                    //    if (judge == "ｙ") {
                    PrefectureDict[prefecture].Add(cityinfo);
                    //    }
                }
                else {
                    PrefectureDict[prefecture] = new List<CityInfo> { cityinfo };
                }

                Console.Write("県名:");
                prefecture = Console.ReadLine();

            }
            Console.WriteLine("1:一覧表,2:県名指定");
            Console.Write(">");
            string num = Console.ReadLine();
            if (num == "1") {
                foreach (var s in PrefectureDict) {
                    Console.WriteLine("<<{0}>>:",s.Key);
                    foreach (var term in s.Value) {
                        Console.Write("|{0}:{1}人|", term.City, term.Population);
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.Write("県名を入力:");
                string pre = Console.ReadLine();
                foreach (var term in PrefectureDict[pre]) {
                    Console.Write("|{0}:{1}人|", term.City, term.Population);
                }
            }
        }

        class CityInfo {
            public string City { get; set; }         //都市
            public int Population { get; set; }     //人口
        }
    }
}
