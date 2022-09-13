using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    public class NamesWithPrice
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public NamesWithPrice(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
