using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelCardCodeKata;

namespace TravelCardCodeKataUnitTests
{
    [TestClass]
    public class TravelCardTests
    {
        [TestMethod]
        public void testBuyTicketWithMoneyOnTheCard() {
            TravelCard testCard = new TravelCard();
            testCard.extendBalance(50);

            bool result = testCard.buyTicket();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void testBuyTicketWithoutMoneyOnTheCard() {
            TravelCard testCard = new TravelCard();
            bool result = testCard.buyTicket();

            Assert.IsFalse(result);
        }
    }
}
