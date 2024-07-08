using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public enum FoodType 
    {
        Appetizers,
        Plates,
        Sandwiches,
        Desserts
    }
    public class Food
    {
        public decimal price { get; set; }
        public FoodType type { get; set; }
        public int temperatureInC { get; set; }
        public string name { get; set; }
        public Food(FoodType type)
        {
            this.type = type;
        }
        private string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(type.ToString()).Append(": ").AppendLine()
                .Append(name).AppendLine()
                .Append(temperatureInC.ToString())
                .Append(price.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
