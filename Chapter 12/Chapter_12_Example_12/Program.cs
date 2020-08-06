using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Chapter_12_Example_12
{
    [Serializable]
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Author author = new Author();
            author.Id = 1;
            author.FirstName = "Joydip";
            author.LastName = "Kanjilal";
            author.Address = "Hyderabad, India";

            FileStream fileStreamObject = new FileStream(@"D:\author.soap", FileMode.Create);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStreamObject, author);
            fileStreamObject.Close();

            fileStreamObject = new FileStream(@"D:\author.soap", FileMode.Open);
            soapFormatter = new SoapFormatter();
            author = (Author)soapFormatter.Deserialize(fileStreamObject);
            fileStreamObject.Close();
            Console.WriteLine(author.Id + "\t" + author.FirstName + "\t" + author.LastName + "\t" + author.Address);
            Console.Read();
        }
    }
}
