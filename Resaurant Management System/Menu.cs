using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    internal class Menu
    {
        public StringBuilder menu { get; set; }

        public void BuildMenu()
        {
            menu = new StringBuilder();
            menu.Append("Appetizers: Cheese Bread").AppendLine()
                .Append("Plates: Pepperoni Pizza").AppendLine()
                .Append("Sandwiches: Taouk Sandwich").AppendLine()
                .Append("Desserts: Teta Pudding").AppendLine()
                .Append("Ice Cream Extra (Red Velvet)").AppendLine();
        }
        public string GetMenu()
        {
            return menu.ToString();
        }
    }
}
