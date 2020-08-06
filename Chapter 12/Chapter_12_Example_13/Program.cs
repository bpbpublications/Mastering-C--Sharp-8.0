using System;
using System.IO;
using System.Xml.Serialization;

namespace Chapter_12_Example_13
{
    [Serializable]
    class Author
    {
        public int Id { get; set; }  public string FirstName { get; set; }  public string LastName { get; set; }   public string Address { get; set; }
    }
    class Program
    {
        public static void Serialize(Author author, string filename)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;
            try
            {
                serializer = new XmlSerializer(typeof(Author));  stream = new FileStream(filename, FileMode.Create);  serializer.Serialize(stream, author);
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        public static Author Deserialize(string filename)
        {
            XmlSerializer serializer = null;
            FileStream stream = null;
            Author author = new Author();
            try
            {
                serializer = new XmlSerializer(typeof(Author));  stream = new FileStream(filename, FileMode.Open);
                return (Author)serializer.Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Id = 1;
            author.FirstName = "Joydip";
            author.LastName = "Kanjilal";
            author.Address = "Hyderabad, India";
            Serialize(author, @"D:\author.xml");
            author = Deserialize(@"D:\author.xml");
            Console.WriteLine(author.Id + "\t" + author.FirstName + "\t" + author.LastName + "\t" + author.Address);
            Console.Read();
        }
    }
}
