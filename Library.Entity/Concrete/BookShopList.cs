using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.Concrete
{
    public class BookShopList
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }  
        public int TotalOfPages { get; set; }    
        public decimal UserScore { get; set; }
    }
}
