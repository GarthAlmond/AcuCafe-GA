using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    static class FactoryDrinks
    {
        //Discovered this a while ago on a Java project.
        //Same in C#. Works well when creating objects like this.
        public static IDrink GetDrink(string type)
        {
            IDrink drink = null;

            switch (type)
            {
                case "Expresso":
                    drink =  new Expresso();
                    break;
                case "HotTea":
                    drink = new Tea();
                    break;
                case "IceTea":
                    drink = new IceTea();
                    break;
                default:
                    drink = new Drink();
                    break;
            }
            return drink;
        }
    }
}
