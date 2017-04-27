namespace AcuCafe
{
    public class Tea : Drink
    {
        // The Tea class; based on Drink with overrides to make it specificaly Tea
        public override string Description
        {
            get { return "Hot tea"; }
        }

        public override double Cost()
        {
            double cost = 1;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }
    }
}