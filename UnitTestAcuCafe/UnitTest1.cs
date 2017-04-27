using System;
using AcuCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcuCafe;

namespace UnitTestAcuCafe
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void OrderExpressoMilkandSugarandChocTopping()
        {
            double expected = 3.3;

            var drink = AcuCafeOrders.OrderDrink("Expresso", true, true, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Expresso with Milk and sugar and Choc Topping is wrong.");
        }
        [TestMethod]
        public void OrderExpressoMilkandSugarandChocToppingMessage()
        {
            var expected = "We are preparing the following drink for you: Expresso with milk with sugar with chocolate topping";

            var drink = AcuCafeOrders.OrderDrink("Expresso", true, true, true);
            var actual = drink.Message;

            Assert.AreEqual(expected, actual, "Message for Expresso with Milk and sugar and Choc Topping is wrong.");
        }
        [TestMethod]
        public void OrderExpressoMilkandSugar()
        {
            double expected = 2.8;

            var drink = AcuCafeOrders.OrderDrink("Expresso", true, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Expresso with Milk and sugar is wrong.");
        }
        [TestMethod]
        public void OrderExpressoMilkandNoSugar()
        {
            double expected = 2.3;

            var drink = AcuCafeOrders.OrderDrink("Expresso", true, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Expresso with Milk and no sugar is wrong.");
        }
        [TestMethod]
        public void OrderExpressoNoMilkandWithSugar()
        {
            double expected = 2.3;

            var drink = AcuCafeOrders.OrderDrink("Expresso", false, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Expresso No Milk and with sugar is wrong.");
        }
        [TestMethod]
        public void OrderExpressoNoMilkandNoSugar()
        {
            double expected = 1.8;

            var drink = AcuCafeOrders.OrderDrink("Expresso", false, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Expresso No Milk and No sugar is wrong.");
        }

        [TestMethod]
        public void OrderTeaMilkandSugar()
        {
            double expected = 2.0;

            var drink = AcuCafeOrders.OrderDrink("HotTea", true, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Tea with Milk and sugar is wrong.");
        }
        [TestMethod]
        public void OrderTeaMilkandNoSugar()
        {
            double expected = 1.5;

            var drink = AcuCafeOrders.OrderDrink("HotTea", true, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Tea with Milk and no sugar is wrong.");
        }
        [TestMethod]
        public void OrderTeaNoMilkandWithSugar()
        {
            double expected = 1.5;

            var drink = AcuCafeOrders.OrderDrink("HotTea", false, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Tea No Milk and with sugar is wrong.");
        }
        [TestMethod]
        public void OrderTeaNoMilkandNoSugar()
        {
            double expected = 1.0;

            var drink = AcuCafeOrders.OrderDrink("HotTea", false, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Tea No Milk and No sugar is wrong.");
        }

        [TestMethod]
        public void OrderIceTeaMilkandSugar()
        {
            double expected = 2.0;

            var drink = AcuCafeOrders.OrderDrink("IceTea", true, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Ice Tea with Milk and sugar is wrong.");
        }
        [TestMethod]
        public void OrderIceTeaMilkandNoSugar()
        {
            // Iced Tea can not have milk
            double expected = 1.5;

            var drink = AcuCafeOrders.OrderDrink("IceTea", true, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Ice Tea with Milk and no sugar is wrong.");
        }
        [TestMethod]
        public void OrderIceTeaNoMilkandWithSugar()
        {
            double expected = 2.0;

            var drink = AcuCafeOrders.OrderDrink("IceTea", false, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Ice Tea No Milk and with sugar is wrong.");
        }
        [TestMethod]
        public void OrderIceTeaNoMilkandNoSugar()
        {
            // Iced Tea can not have milk
            double expected = 1.5;

            var drink = AcuCafeOrders.OrderDrink("IceTea", false, false);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Price for Ice Tea No Milk and No sugar is wrong.");
        }

        [TestMethod]
        public void OrderIceCoffeeMilkandSugar()
        {
            // No Iced Coffee so should gt 0 cost back.
            double expected = 0;

            var drink = AcuCafeOrders.OrderDrink("IceCoffee", true, true);
            var actual = drink.Cost();

            Assert.AreEqual(expected, actual, "Ice Coffee test failed.");
        }
        [TestMethod]
        public void OrderIceCoffeeMilkandSugarMessage()
        {
            string expected = "Error creating drink.";

            var drink = AcuCafeOrders.OrderDrink("IceCoffee", true, true);
            var actual = drink.Message;

            Assert.AreEqual(expected, actual, "Ice Coffee test failed.");
        }

    }
}
