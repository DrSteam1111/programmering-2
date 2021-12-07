using System;
using System.Collections.Generic;

namespace Banking
{
    public class BankAccount
    {
        private string pin;
        private string accountNumber;
        private int balance;
        private List<Transfer> successfullTransfers;

        public BankAccount(string accountNumber, string pin)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
            this.balance = 0;
            this.successfullTransfers = new List<Transfer>();
        }
        public BankAccount(string accountNumber, string pin, int balance) : this(accountNumber, pin)
        {
            this.balance = balance;
        }
        public String AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Transfer(Transfer transfer)
        {
            if (transfer.FromAccountNr == accountNumber && transfer.Amount <= balance)
            {
                balance -= transfer.Amount;
                successfullTransfers.Add(transfer);
                return true;
            }
            else if (transfer.ToAccountNr == accountNumber)
            {
                balance += transfer.Amount;
                successfullTransfers.Add(transfer);
                return true;
            }
            return false;
        }

        public bool ValidatePin(string pin)
        {
            if (pin != this.pin)
                return false;

            foreach (char c in pin)
            {
                if (c > '0' || c < '9')
                    return true;
            }

            return false;
        }

        public string GetAllTransfersAsString()
        {
            throw new NotImplementedException();
        }
        public List<Transfer> GetTransfers()
        {
            return successfullTransfers;
        }
    }
}
