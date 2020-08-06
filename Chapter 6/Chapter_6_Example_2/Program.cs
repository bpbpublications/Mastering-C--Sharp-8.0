using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_6_Example_2
{
    class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        public static List<Author> Authors = new List<Author>
            {
                new Author {ID = 1, FirstName = "Terry", LastName = "Adams", Address = "USA" },
                new Author {ID = 2, FirstName = "Joydip", LastName = "Kanjilal", Address = "Hyderabad, INDIA" },
                new Author {ID = 3, FirstName = "Michael", LastName = "Smith", Address = "USA" },
                new Author {ID = 4, FirstName = "Steve", LastName = "Smith", Address = "USA" },
                new Author {ID = 5, FirstName = "Anand", LastName = "Naraswamy", Address = "Cochin, INDIA" }
            };
        static void Main(string[] args)
        {
            var result = from a in Authors orderby a.FirstName select a;
            //var result = from a in Authors where a.ID == 1 select a;
            //var result = from a in Authors.Where(x => x.FirstName == "Joydip") select new { a.FirstName, a.LastName };

            foreach (var author in result)
                Console.WriteLine(author.FirstName + "\t" + author.LastName);
            Console.Read();
        }
    }
}
