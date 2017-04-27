namespace AcuCafe
{
    public class Expresso : Drink
    {
        // The Expresso class; based on Drink with overrides and extended to make it specificaly Expressio
        // Highly likely to change so it would be best to pass it in from the outside in a product app.
        public const double ChocToppingCost = 0.5;

        public bool HasChocTopping;

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

        public void ChocTopping(bool hasChocTopping)
        {
            HasChocTopping = hasChocTopping;
        }

        public override void Prepare()
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

                if (HasChocTopping)
                    Message += " with chocolate topping";
                else
                    Message += " without chocolate topping";
            }

        }
    }
}