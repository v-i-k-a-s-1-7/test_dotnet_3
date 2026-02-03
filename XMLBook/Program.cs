using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Year = 1925,
                edition = new List<string?> { "First Edition" , "Second Edition", "Third Edition" }
            };



            XmlSerializer serializer = new XmlSerializer(typeof(Book));

            // Serialize the book to XML
            serializer.Serialize(Console.Out, myBook);
            Console.Out.WriteLine(myBook);


        }
    }
}
