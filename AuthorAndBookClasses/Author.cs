using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorAndBookClasses
{
    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public char gender { get; set; }

        public void toStringAuthor()
        {
            Console.WriteLine($"Author[name={name}, email={email}, gender={gender}]");
        }
    }
    

}
