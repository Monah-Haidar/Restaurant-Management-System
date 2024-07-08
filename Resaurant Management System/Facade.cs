using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public class Facade
    {
        public IInvoice invoice;
        public IPrintable printable;

        public Facade()
        {
            Info info = new Info();
            invoice = info;
            printable = info;
        }
        public decimal GetTotal()
        {
            return invoice.GetTotal();
        }
        public decimal GetPrice(Food food)
        {
            return food.price;
        }
        public void AddToInvoice(Food food)
        {
            invoice.AddToInvoice(food);
        }
        public string GetMenu()
        {
            return printable.GetMenu();
        }
        public string GetReceipt()
        {
            return printable.GetReceipt();
        }
    }
}
