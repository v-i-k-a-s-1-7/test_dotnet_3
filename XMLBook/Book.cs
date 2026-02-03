using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLBook
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public List<string?> edition { get; set; }
    }


}
