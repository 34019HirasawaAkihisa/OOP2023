using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            // var exists = list.Exists(s => s[3] == 'y');
            //  Console.WriteLine(exists);

            var names = list.ConvertAll(s => s.ToUpper());
            names.ForEach(s => Console.WriteLine(s));
            
        }
    }
}
