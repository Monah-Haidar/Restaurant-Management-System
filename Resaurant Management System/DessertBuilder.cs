using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public class DessertBuilder : FoodBuilder
    {
        public DessertBuilder()
        {
            food = new Food(FoodType.Desserts);
        }
        public override void BuildPrice(decimal price)
        {
            food.price = price;
        }
        public override void BuildTemperatureInC(int temp)
        {
            food.temperatureInC = temp;
        }
        public override void BuildName()
        {
            food.name = "Teta Pudding";
        }
    }
}
