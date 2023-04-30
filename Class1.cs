using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace view
{
    public class Product
    {
        public string prod_name;
        public int price, count;
        public Product(string _prod_name, int _price, int _count)
        {
            prod_name = _prod_name;
            price = _price;
            count = _count;
        }
    }
}
