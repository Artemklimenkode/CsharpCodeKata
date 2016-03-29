using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelCardCodeKata;

namespace TravelCardCodeKataUnitTests
{
    [TestClass]
    public class TravelCardTests
    {
        private TravelCard testCard;

        [TestInitialize]
        public void setUp()
        {
            this.testCard = new TravelCard();
        }

        [TestMethod]
        public void testBuyTicketWithMoneyOnTheCard()
        {
            testCard.extendBalance(50);

            bool result = testCard.buyTicket();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void testBuyTicketWithoutMoneyOnTheCard()
        {
            bool result = testCard.buyTicket();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void testNewCardBalanceEqualsToZero()
        {
            Assert.AreEqual(0, testCard.getBalance());
        }

        [TestMethod]
        public void testExtendBalance()
        {
            double amount = 50;
            testCard.extendBalance(amount);

            Assert.AreEqual(amount, testCard.getBalance());
        }

        [TestMethod]
        public void testIfBalanceChangesWhenBuyingATicket()
        {
            double originalBalance = 50;
            testCard.extendBalance(originalBalance);

            bool wasSuccessful = testCard.buyTicket();
            Assert.IsTrue(wasSuccessful);
            Assert.IsTrue(originalBalance > testCard.getBalance());
        }

        [TestMethod]
        public void testDiscount()
        {
            double originalBalance = 50;
            testCard.extendBalance(originalBalance);
            testCard.buyTicket();

            double balanceAfterFirstTicket = this.testCard.getBalance();
            double ticketPriceWithoutDiscount = originalBalance - balanceAfterFirstTicket;

            this.testCard.setDiscount(50);
            testCard.buyTicket();
            double ticketPriceWithDiscount = balanceAfterFirstTicket - this.testCard.getBalance();

            Assert.IsTrue(ticketPriceWithoutDiscount > ticketPriceWithDiscount);
        }

        [TestMethod]
        public void testDiscountWithZero()
        {
            double originalBalance = 50;
            testCard.extendBalance(originalBalance);

            testCard.buyTicket();

            double ticketPriceWithoutDiscount = originalBalance - this.testCard.getBalance();

            testCard.setDiscount(0);
            originalBalance = this.testCard.getBalance();
            testCard.buyTicket();
            double ticketPriceWithZeroDiscount = originalBalance - this.testCard.getBalance();
            Assert.AreEqual(ticketPriceWithoutDiscount, ticketPriceWithZeroDiscount);
            Assert.AreNotEqual(ticketPriceWithZeroDiscount, 0);
        }

        [TestMethod]
        public void testDiscountWithMoreThanOneHundred()
        {
            testCard.setDiscount(200);
            Assert.AreEqual(100, testCard.getDiscount());

        }

        [TestMethod]
        public void testDiscountWithMLessThanAZero()
        {
            testCard.setDiscount(-200);
            Assert.AreEqual(0, testCard.getDiscount());
        }

        [TestMethod]
        public void testSeasonalTicketForDays()
        {
            Assert.AreEqual(false, this.testCard.isSeasonalTicketValid());
            testCard.buySeasonalTicket(5);

            Assert.AreEqual(true, this.testCard.isSeasonalTicketValid());
        }

        [TestMethod]
        public void testSeasonalTicketForAmountWithChange()
        {
            Assert.AreEqual(false, this.testCard.isSeasonalTicketValid());
            double change = testCard.buySeasonalTicketForAmount(100.50);

            Assert.AreEqual(true, this.testCard.isSeasonalTicketValid());
            Assert.AreEqual(0.50, change, 0.05);
        }

        [TestMethod]
        public void testSeasonalTicketForAmountWithoutChange()
        {
            Assert.AreEqual(false, this.testCard.isSeasonalTicketValid());
            double change = testCard.buySeasonalTicketForAmount(100);

            Assert.AreEqual(true, this.testCard.isSeasonalTicketValid());
            Assert.AreEqual(0, change, 0.05);
        }
    }
}
