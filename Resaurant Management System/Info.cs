using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    internal class Info : IInvoice, IPrintable
    {
        public List<Food> food;
        public decimal total { get; set; }
        public Invoice invoice;
        public Menu menu;

        public Info()
        {
            food = new List<Food>();
            invoice = new Invoice();
            menu = new Menu();
        }
        public void AddToInvoice(Food f)
        {
            this.food.Add(f);
            invoice.AddLine(f);
            invoice.CalculateTotal(food);
        }
        public string GetMenu()
        {
            menu.BuildMenu();
            return menu.GetMenu();
        }
        public string GetReceipt()
        {
            return invoice.ToString();
        }
        public decimal GetTotal()
        {
            return invoice.GetTotal();
        }
        public decimal GetPrice(Food food)
        {
            return food.price;
        }

    }
}
