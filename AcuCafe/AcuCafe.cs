using System;
using System.Diagnostics;
using System.Xml;

namespace AcuCafe
{
    public class AcuCafeOrders
    //Bad idea to name a class the same as the namespace as it causes confution
    {
        public static IDrink OrderDrink(string type, bool hasMilk, bool hasSugar, bool hasChocTopping = false)
        {
            var drink = FactoryDrinks.GetDrink(type);
            // If a valid "type" is not passed in we'll get empty drink and its Description will be null;

            try
            {
                drink.HasMilk = hasMilk;
                drink.HasSugar = hasSugar;
                if (drink.Description == "Expresso")
                {
                    // Cast drink to Expresso to be access the extra properties it has.
                    Expresso expresso = (Expresso) drink;
                    expresso.HasChocTopping = hasChocTopping;
                }

                drink.Prepare();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("We are unable to prepare your drink.");
                //System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                //Need toget some sort of loger in here, probably don't have access right to c:\
                // and thats a bad place to be writing error messages.
                //TODO
            }

            return drink;
        }
    }
}