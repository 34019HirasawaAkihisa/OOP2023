using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            Console.WriteLine("{0} {1}",dateTime.ToString("d"),dateTime.ToString("t"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            Console.WriteLine(dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒"));
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dateTime.ToString("ggyy年M月d日(dddd)", culture));         
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            
        }
    }
}
