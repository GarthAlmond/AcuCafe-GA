namespace AcuCafe
{
    public class IceTea : Drink
    {
        // The IceTea class; based on Drink with overrides to make it specificaly IceTea
        public override string Description
        {
            get { return "Ice tea"; }
        }

        // Iced Tea can NOT have milk
        public override bool HasMilk
        {
            get { return false; }
        }

        public override double Cost()
        {
            double cost = 1.5;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}