using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCardCodeKata
{

    public class TravelCard
    {
        double currentBalance;
        double ticketPrice = 2;
       double basicPrice = 2;
        double discounted = 0;
        bool discountSet = false;
        public bool buyTicket()
        {
            if (this.currentBalance >= ticketPrice)
            {
                this.currentBalance = currentBalance - ticketPrice;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void buySeasonalTicket(int forDays)
        {

        }
        public void buySeasonalTicketForAmount(Double withBalance)
        {

        }
        public DateTime getSeasonalExpireDate()
        {
            DateTime expiryDate = new DateTime();
            return expiryDate;
        }
        public void extendBalance(double withAmount)
        {
            this.currentBalance = withAmount;
        }
        public Double getBalance()
        {
            return this.currentBalance;
        }
        public void setDiscount(double discountValue)
        {
            
            this.ticketPrice = basicPrice - basicPrice * (discountValue / 100);
          
        }

    }
}
