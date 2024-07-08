using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    internal class Invoice
    {
        public decimal total { get; set; }

        public List<InvoiceLine> invoiceLines;

        public Invoice()
        {
            invoiceLines = new List<InvoiceLine>();
        }
        public void AddLine(Food food)
        {
            invoiceLines.Add(new InvoiceLine(food));
        }
        public void CalculateTotal(List<Food> food)
        {
            total = 0;
            foreach(Food f in food)
            {
                total += f.price;
            }
        }
        public decimal GetTotal()
        {
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(InvoiceLine iL in invoiceLines)
            {
                sb.Append(iL.ToString()).AppendLine();
            }
            sb.Append("Total: ").Append(total.ToString());
            return sb.ToString();
        }
    }
}
