using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            //設定ファイルのシリアル化
            var emp = new Employee {
                Id = 123,
                Name = "高野敦",
                HireDate = new DateTime(2023, 9, 5)
            };
            using (var writer = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
            //逆シリアル化
            using (var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "高野敦",
                    HireDate = new DateTime(2023, 9, 5)
                },
                 new Employee {
                     Id = 123,
                     Name = "新里孝弘",
                     HireDate = new DateTime(2023, 9, 5)
                 },
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            using(var writer = XmlWriter.Create(v, settings)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
            }
        }

        private static void Exercise1_3(string v) {
            using (var reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var emp in emps) {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.HireDate);
                }
            }
        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "高野敦",
                    HireDate = new DateTime(2023, 9, 5)
                },
                 new Employee {
                     Id = 123,
                     Name = "新里孝弘",
                     HireDate = new DateTime(2023, 9, 5)
                 },
            };
            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(stream, emps);
            }
        }
    }
}
[DataContract]
public class Employee2 {
    public int Id { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "hireDate")]
    public DateTime HireDate { get; set; }
}