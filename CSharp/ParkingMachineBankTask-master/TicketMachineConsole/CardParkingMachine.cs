using System;
using System.Collections.Generic;
using System.Text;
using Banking;

namespace Parking
{
    public class CardParkingMachine : ParkingMachine
    {
        private Bank bank;
        private String accountNr;
        private String customerAccountNr;
        private String customerPin;

        public CardParkingMachine(int costPerHour, Bank bank, String accountNr) : base(costPerHour)
        {
            this.bank = bank;
            this.accountNr = accountNr;
        }
        public void SetAccountNrAndPin(String accountNr, String pin)
        {
            this.customerAccountNr = accountNr;
            this.customerPin = pin;
        }
        public bool IsSetAccountNrAndPin()
        {
            if (this.customerAccountNr == null || this.customerPin == null)
            {
                return false;
            }
            return true;
        }
        public new Ticket BuyTicket()
        {
            if (!IsSetAccountNrAndPin()) return null;
            if (bank.GetBalance(customerAccountNr, customerPin) == 0) return null;
            if (!(bank.Transfer(new Transfer(customerAccountNr, accountNr, CurrentTotal), customerPin))) return null;
            
            customerAccountNr = null;
            customerPin = null;
              
            return base.BuyTicket();
        }

    }
}
