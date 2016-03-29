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
        DateTime expiryDate;

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
        
        /// <summary>
        /// Purchases tickets for the given number of days.
        /// </summary>
        /// <param name="forDays">Defines the number of days for which the seasonal ticket should be purchased for</param>
        public void buySeasonalTicket(int forDays)
        {
            if (forDays > 0)
            {
                if (isSeasonalTicketValid())
                {
                    this.expiryDate.AddDays(forDays);
                }
                else
                {
                    this.expiryDate = this.getCurrentDate().AddDays(forDays);
                }
            }
        }
        
        public double buySeasonalTicketForAmount(Double withBalance)
        {
            if (withBalance > 0)
            {
                int amountOfDays = convertBalanceToDays(withBalance);
                this.buySeasonalTicket(amountOfDays);
                
                return this.getChangeFromAmount(withBalance);
            }
            return 0;
        }
        
        private int convertBalanceToDays(Double balance)
        {
            if (balance > 0)
            {
                int amountOfDays = (int)(balance / getTicketPrice());
                return amountOfDays;
            }
            return 0;

        }
        private double getChangeFromAmount(Double amount)
        {
            if (amount > 0)
            {
                double change = amount % getTicketPrice();
                return change;
            }

            return 0;
        }

        public DateTime getSeasonalExpiryDate()
        {
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
        {   if (discountValue > 100)
            {
                this.discount = 100;
            }
            else if (discountValue < 0)
            {
                this.discount = 0;
            }

            else { this.discount = discountValue; }
        }
        public double getDiscount()
        {
            return discount;
        }

        public bool isSeasonalTicketValid() {
            return this.getCurrentDate() <= this.expiryDate;
        }

        private double getTicketPrice() {
            return basicPrice * ((100 - this.discount) / 100);
        }

        private DateTime getCurrentDate() {
            return DateTime.Now;
        }
    }
}
