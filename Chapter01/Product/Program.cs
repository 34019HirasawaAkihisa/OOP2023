using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            #region  P26のサンプルプログラム
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daihuku = new Product(235, "大福もち", 160);

            //Console.WriteLine(karinto.GetPriceIncludingTax());
            //Console.WriteLine(daihuku.GetPriceIncludingTax());
            #endregion

            #region　演習１
            //DateTime data = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;
            string str = date.ToString("yyyy年MM月dd日");

            Console.WriteLine("今日の日付:" + str);

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("10日後:" + daysAfter10.ToString("yyyy年MM月dd日") +  "です。");

            //10日前を求める
            DateTime daysBefor10 = date.AddDays(-10);
            Console.WriteLine("10日前:" + daysBefor10.ToString("yyyy年MM月dd日") + "です。");
            #endregion

            #region　演習２
            Console.WriteLine("誕生日を入力:");
            Console.Write("西暦:");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            DateTime dateToday = DateTime.Today;

            TimeSpan time = dateToday - birthday;

            Console.WriteLine("あなたは生まれてから今日まで" + (time.Days) + "日目です");
            #endregion

            #region　演習３
            Console.WriteLine("あなたは" + birthday.ToString("dddd") + "に生まれました。");
            #endregion
        }
    }
}
