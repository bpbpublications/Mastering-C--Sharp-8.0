using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter_12_Example_11
{
    [Serializable]
    class Author
    {
        public int Id { get; set; }  public string FirstName { get; set; }   public string LastName { get; set; }  public string Address { get; set; }
    }
    class Program
    {
        static void Serialize(Author author)
        {
            FileStream fileStreamObject = null;
            try
            {
                fileStreamObject = new FileStream(@"D:\author.bin", FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStreamObject, author);
            }
            finally
            {
                fileStreamObject.Close();
            }
        }
        static Author Deserialize()
        {
            FileStream fileStreamObject = null;

            try
            {
                fileStreamObject = new FileStream(@"D:\author.bin", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                return (Author)(binaryFormatter.Deserialize(fileStreamObject));
            }
            finally
            {
                fileStreamObject.Close();
            }
        }
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Id = 1;
            author.FirstName = "Joydip";
            author.LastName = "Kanjilal";
            author.Address = "Hyderabad, India";
            Serialize(author);
            author = Deserialize();
            Console.WriteLine(author.Id + "\t" + author.FirstName + "\t" + author.LastName + "\t" + author.Address);
            Console.Read();
        }
    }
}
