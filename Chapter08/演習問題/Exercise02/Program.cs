using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var datetime = DateTime.Now;
            var now = datetime.ToString("d");
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek)) ) {
                var next = NextDay(datetime, (DayOfWeek)dayofweek).ToString("yyyy/M/d/(ddd)");
                Console.WriteLine("{0}の次週の{1}:{2}",now,dayofweek,next);
            }
        }
        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days >= -1)
                days += 7;
            return date.AddDays(days);
        }
    }
}
