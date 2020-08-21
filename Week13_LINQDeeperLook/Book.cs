using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_LINQDeeperLook
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }


        public override string ToString() => $"Title: {Title} ({PublicationYear}), Author: {Author}";
    }
}
