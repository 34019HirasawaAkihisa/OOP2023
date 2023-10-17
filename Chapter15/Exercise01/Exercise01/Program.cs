using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(s => s.Price);
            var book = Library.Books.First(s => s.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(s => s.PublishedYear);
            foreach (var item in books) {
                Console.WriteLine("{0}年{1}冊", item.Key, item.Count());
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price)
                                                                             .Join(Library.Categories,
                                                                             book => book.CategoryId,
                                                                             category => category.Id,
                                                                             (book, category) => new {
                                                                                 pub = book.PublishedYear,
                                                                                 price = book.Price,
                                                                                 title = book.Title,
                                                                                 category = category.Name
                                                                             });
            foreach (var item in books) {
                Console.WriteLine("{0}年{1}円{2}({3})", item.pub, item.price, item.title, item.category);
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                             book => book.CategoryId,
                                             category => category.Id,
                                             (book, catogory) => catogory.Name)
                                             .Distinct();
            foreach (var item in names) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Categories.GroupJoin(Library.Books,
                                 c => c.Id,
                                 b => b.CategoryId,
                                 (c, books) => new { Category = c.Name, books = books });
            foreach (var item in groups.OrderBy(s => s.Category)) {
                Console.WriteLine("#{0}",item.Category);
                foreach (var book in item.books) {
                    Console.WriteLine("  {0}", book.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books.Where(b => b.CategoryId == catid).GroupBy(b => b.PublishedYear)
                                      .OrderBy(b => b.Key);
            foreach (var group in groups) {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var book in group) {
                    Console.WriteLine("{0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books,
                                 c => c.Id,
                                 b => b.CategoryId,
                                 (c, books) => new { Category = c.Name, Count = books.Count()});
            foreach (var item in groups) {
                if(item.Count >= 4) {
                    Console.WriteLine(item.Category);
                }
            }
        }
    }
}
