using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppCore.Entites
{
    public class Products
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string category { get; set; }
        public decimal unit_price { get; set; }
        public DateTime Expireydate { get; set; }
        
    }
}
