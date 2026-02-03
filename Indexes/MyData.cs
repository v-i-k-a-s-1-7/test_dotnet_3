using System;
using System.Collections.Generic;
using System.Text;

namespace Indexes
{
    internal class MyData
    {
        private string[] values = new string[3];

        // Indexer to get or set values in the array
        public string this[int index]
        {
            get { 
                return values[index]; 
            }
            set {
                values[index] = value; 
            }
        }
    }
}
