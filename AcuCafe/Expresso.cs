using System.IO;

namespace AcuCafe
{
    public class Expresso : Drink, IExpresso
    {
        // The Expresso class; based on Drink with overrides and extendes to make it specificaly Expressio
        // Highly likely to change so it would be best to pass it in from the outside in a product app.
        // So keeps the Drink class closed and gains some inteface seperation, as the Tea's don't require the extras Expresso needs.
        public const double ChocToppingCost = 0.5;

        public bool HasChocTopping { get; set; }

        public override string Description
        {
            get { return "Expresso"; }
        }

        public override double Cost()
        {
            //This is something that is highly likely to change so in the real world would be passing this in from outside.
            //A configuration, data table or other easily changable source.
            // Basicaly we would not want ot edit and recompile every time the base price changed.
            double cost = 1.8;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            if (HasChocTopping)
                cost += ChocToppingCost;

            return cost;
        }

        public override void Prepare()
        {

            base.Prepare();
            if (Message.StartsWith("Error"))
                //If we have an errormessage the just return from here and don't add to the message.
                return;

            if (HasChocTopping)
                Message += " with chocolate topping";
            else
                Message += " without chocolate topping";
        }

    }
}