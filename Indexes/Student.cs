// 

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace Indexes
{
    public class Student
    {
        public int Rno { get; set; }
        public string? Name { get; set; }

        public string? DateOfBirth { get; private set; }
        public YoungProfessional()
        {

        }

        public YoungProfessional(string dob)
        {
            DateOfBirth = dob;
        }

        private string Address {

            get
            {
                return Address;
            }
        }

        //private string[] Books = new string[3];

        private List<string> MusicAlbums = new List<string>();

        public string this[int index]
        {
            get
            {
                return MusicAlbums[index];
            }
            set
            {
                while(MusicAlbums.Count <= index)
                {
                    MusicAlbums.Add(string.Empty);
                }
                MusicAlbums[index] = value;
            }
        }



    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();

            s1[0] = "The Thousand Splendid Sun";
            s1[1] = "Harry Potter Part 1";
            s1[2] = "The Invisible Man";
            s1[3] = "The Invisible Man";
            s1[4] = "The Invisible Man";
            s1[5] = "The Invisible Man";

            //s1.MusicAlbums[0] = 

            Console.WriteLine("The First Book in his collection is: " + s1[0]);
            Console.WriteLine("The Second Book in his collection is: " + s1[1]);
            Console.WriteLine("The Third Book in his collection is: " + s1[2]);
            Console.WriteLine("The Third Book in his collection is: " + s1[3]);
            Console.WriteLine("The Third Book in his collection is: " + s1[4]);
            Console.WriteLine("The Third Book in his collection is: " + s1[5]);

        }
    }
}
