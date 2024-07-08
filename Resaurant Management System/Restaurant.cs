using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PerlaMonahElias_projectCSC323
{
    public enum ZoneType
    {
        SmokingArea,
        OutdoorArea,
        NonSmokingArea
    }
    public class Restaurant
    {
        public string restaurantName { get; set; }
        public string restaurantAddress { get; set; }
        public int nbOfEmployees { get; set;}
        public string phoneNumber { get; set; }
        public DateTime openingHours { get; set; }
        public Facade facade;
        public ITable table;

        public Restaurant()
        {
            this.facade = new Facade();
            SetZone(ZoneType.NonSmokingArea);
        }
        public Restaurant(ZoneType type)
        {
            this.facade = new Facade();
            SetZone(type);
        }
        public void SetZone(ZoneType type)
        {
            if (type == ZoneType.SmokingArea)
                table = new SmokingArea();
            else if (type == ZoneType.OutdoorArea)
                table = new OutdoorArea();
            else if (type == ZoneType.NonSmokingArea)
                table = new NonSmokingArea();
        }
        public void BuildFood(FoodBuilder foodBuilder, Form1 input)
        {
            foodBuilder.BuildPrice(input.price);
            foodBuilder.BuildTemperatureInC(input.temperature);
            foodBuilder.BuildName();
            facade.AddToInvoice(foodBuilder.food);
        }
        public decimal GetTotal()
        {
            return facade.GetTotal();
        }
        public string GetMenu()
        {
            return facade.GetMenu();
        }
        public string GetReceipt()
        {
            return facade.GetReceipt();
        }
    }
}
