using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    internal class InvoiceLine
    {
        public decimal price { get; set; }
        public string name { get; set; }

        public InvoiceLine(Food food)
        {
            price = food.price;
            name = food.name;
        }
        public override string ToString()
        {
            return name + ": " + price.ToString();
        }
    }
}
