using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var PrefectureDict = new Dictionary<string, CityInfo>() {
            };

            Console.WriteLine("県庁所在地の登録");

            Console.Write("県名:");
            string prefecture = Console.ReadLine();

            while (prefecture != "999") {
                var cityinfo = new CityInfo();

                Console.Write("所在地;");
                cityinfo.City = Console.ReadLine();


                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (PrefectureDict.ContainsKey(prefecture)) {
                    Console.Write("上書きしますか？(y/n):");
                    string judge = Console.ReadLine();

                    if (judge == "ｙ") {
                        PrefectureDict[prefecture] = cityinfo;
                    }
                }
                else {
                    PrefectureDict.Add(prefecture, cityinfo);
                }

                Console.Write("県名:");
                prefecture = Console.ReadLine();

            }
            Console.WriteLine("1:一覧表,2:県名指定");
            Console.Write(">");
            string num = Console.ReadLine();
            if (num == "1") {
                var ob = PrefectureDict.OrderByDescending(s => s.Value.Population);
                foreach (var s in ob) {
                    Console.WriteLine("{0}[{1}(人口:{2})]", s.Key, s.Value.City, s.Value.Population);
                }
            }
            else {
                Console.Write("県名を入力:");
                string pre = Console.ReadLine();
                Console.WriteLine(PrefectureDict[pre].City + PrefectureDict[pre].Population);
            }
        }

        class CityInfo {
            public string City { get; set; }         //都市
            public int Population { get; set; }     //人口
        }
    }
}
