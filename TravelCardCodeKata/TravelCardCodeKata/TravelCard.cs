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
        double basicPrice = 2;
        double discount = 0; 

        public bool buyTicket()
        {
            if (this.currentBalance >= getTicketPrice())
            {
                this.currentBalance = currentBalance - getTicketPrice();
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
            this.discount = discountValue;
        }

        private double getTicketPrice() {
            return basicPrice * ((100 - this.discount) / 100);
        } 
    }
}
