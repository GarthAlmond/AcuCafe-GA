using System;
using System.Diagnostics;

namespace AcuCafe
{
    public class Drink : IDrink
    {
        // The simplest/default Concrete class for a drink.
        // More complex drinks may overrider the default properties and meathods defined here.

        public const double MilkCost = 0.5;
        public const double SugarCost = 0.5;
        //OK for use in an example/excercise, but could be read in from a config file to be more robust.

        public virtual bool HasMilk { get; set; }
        public virtual bool HasSugar { get; set; }

        public virtual string Message { get; set; }
        public virtual string Description { get; }

        public virtual double Cost()
        {
            return 0;
        }

        public virtual void Prepare()
        {
            if (Description == null)
                Message = "Error creating drink.";
            else
            {
            Message = "We are preparing the following drink for you: " + Description;
            if (HasMilk)
                Message += " with milk";
            else
                Message += " without milk";

            if (HasSugar)
                Message += " with sugar";
            else
                Message += " without sugar";
            }

        //Console.WriteLine(message);
            //We have built the Message, but should not be outputing it from here.
            //Leave that up to whatever is using this object, it may not be a Console app.
        }

    }
}