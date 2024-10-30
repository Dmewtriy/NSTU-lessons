using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1;

namespace UnitTestLab1
{
    [TestClass]
    public class lab1Tests
    {
        [TestMethod]
        public void Off_techConstructorWithoutParameters()
        {
            off_tech tech = new off_tech();
            string firmExpected = "firm";
            int weightExpected = 2;
            int priceExpected = 1000;

            string firmActual = tech.Firm;
            int weightActual = tech.Weight;
            int priceActual = tech.Price;

            Assert.AreEqual(firmExpected, firmActual, "Off_tech constructor without parameters does not work correctly");
            Assert.AreEqual(weightExpected, weightActual, "Off_tech constructor without parameters does not work correctly");
            Assert.AreEqual(priceExpected, priceActual, "Off_tech constructor without parameters does not work correctly");

        }

        [TestMethod]
        public void Off_techConstructorWithCorrectParameters() 
        {
            string firm = "Asus";
            int weight = 2;
            int price = 100000;
            off_tech tech = new off_tech(firm, weight, price);

            string firmActual = tech.Firm;
            int weightActual = tech.Weight;
            int priceActual = tech.Price;

            Assert.AreEqual(firm, firmActual, "Off_tech constructor with correct parameters does not work correctly");
            Assert.AreEqual(weight, weightActual, "Off_tech constructor with correct parameters does not work correctly");
            Assert.AreEqual(price, priceActual, "Off_tech constructor with correct parameters does not work correctly");
        }

        [TestMethod]
        public void Off_techConstructorWithUncorrectParameters()
        {
            string firm = "", firmExpected = "firm";
            int weight = -1, weightExpected = 2;
            int price = -5, priceExpected = 1000;

            off_tech tech = new off_tech(firm, weight, price);

            string firmActual = tech.Firm;
            int weightActual = tech.Weight;
            int priceActual = tech.Price;

            Assert.AreEqual(firmExpected, firmActual, "Off_tech constructor with uncorrect parameters does not work correctly");
            Assert.AreEqual(weightExpected, weightExpected, "Off_tech constructor with uncorrect parameters does not work correctly");
            Assert.AreEqual(priceExpected, priceActual, "Off_tech constructor with uncorrect parameters does not work correctly");
        }

        [TestMethod]
        public void FaxConstructorWithoutParameters()
        {
            int resOfPagesExpected = 100;
            bool delay_SendExpected = false;

            Fax fax = new Fax();
            int resOfPagesActual = fax.ResOfPages;
            bool delay_SendActual = fax.Delay_Send;

            Assert.AreEqual(resOfPagesExpected, resOfPagesActual, "Fax constructor without parameters does not work correctly");
            Assert.AreEqual(delay_SendExpected, delay_SendActual, "Fax constructor without parameters does not work correctly");
        }

        [TestMethod]
        public void FaxConstructorWithCorrectParameters()
        {
            int resOfPages = 500;
            bool delay_Send = false;

            Fax fax = new Fax(resOfPages, delay_Send);

            int resOfPagesActual = fax.ResOfPages;
            bool delay_SendActual = fax.Delay_Send;

            Assert.AreEqual(resOfPages, resOfPagesActual, "Fax constructor with correct parameters does not work correctly");
            Assert.AreEqual(delay_Send, delay_SendActual, "Fax constructor with correct parameters does not work correctly");
        }

        [TestMethod]
        public void FaxConstructorWithUncorrectParameters()
        {
            int resOfPages = 0, resOfPagesExpected = 100;
            bool delay_Send = true, delay_SendExpected = true;

            Fax fax = new Fax(resOfPages, delay_Send);

            int resOfPagesActual = fax.ResOfPages;
            bool delay_SendActual = fax.Delay_Send;

            Assert.AreEqual(resOfPagesExpected, resOfPagesActual, "Fax constructor with uncorrect parameters does not work correctly");
            Assert.AreEqual(delay_SendExpected, delay_SendActual, "Fax constructor with uncorrect parameters does not work correctly");
        }


        [TestMethod]
        public void PrinterConstructorWithoutParameters()
        {
            int speed = 2;
            tech_of_print tech = tech_of_print.Undefined;

            Printer printer = new Printer();

            int speedActual = printer.Speed;
            tech_of_print techActual = printer.Tech;

            Assert.AreEqual(speed, speedActual, "Printer constructor without parameters does not work correctly");
            Assert.AreEqual(tech, techActual, "Printer constructor without parameters does not work correctly");
        }

        [TestMethod]
        public void PrinterConstructorWithCorrectParameters()
        {
            int speed = 5;
            tech_of_print tech = tech_of_print.Laser;

            Printer printer = new Printer(speed, tech);

            int speedActual = printer.Speed;
            tech_of_print techActual = printer.Tech;

            Assert.AreEqual(speed, speedActual, "Printer constructor with correct parameters does not work correctly");
            Assert.AreEqual(tech, techActual, "Printer constructor with correct parameters does not work correctly");
        }

        [TestMethod]
        public void PrinterConstructorWithUncorrectParameters()
        {
            int speed = 0, speedExpected = 2;
            tech_of_print tech = tech_of_print.Undefined, techExpected = tech_of_print.Undefined;

            Printer printer = new Printer(speed, tech);

            int speedActual = printer.Speed;
            tech_of_print techActual = printer.Tech;

            Assert.AreEqual(speedExpected, speedActual, "Printer constructor with uncorrect parameters does not work correctly");
            Assert.AreEqual(techExpected, techActual, "Printer constructor with uncorrect parameters does not work correctly");
        }
    }
}
