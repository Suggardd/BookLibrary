using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string description { get; set; }

    }
}
