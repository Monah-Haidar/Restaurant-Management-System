using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public interface IInvoice
    {
        public decimal GetTotal();
        public decimal GetPrice(Food food);
        public void AddToInvoice(Food food);
    }
}
