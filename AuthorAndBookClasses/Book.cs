using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorAndBookClasses
{
    public class Book
    {

        public string name { get; set; }
        public Author author { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
           
		public void toStringBook()
        {
            Console.WriteLine($"Book[name={name},price={price},qty={qty}]");
        }
	
        
        

    }

}
