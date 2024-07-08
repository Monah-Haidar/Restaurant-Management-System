using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public abstract class FoodBuilder
    {
        public Food food { get; set; }

        public abstract void BuildPrice(decimal price);
        public abstract void BuildTemperatureInC(int temp);
        public abstract void BuildName();
    }
}
