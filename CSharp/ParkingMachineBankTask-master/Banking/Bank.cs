using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class Bank
    {
        // all accounts in the bank <account number, bank account>
        private Dictionary<String, BankAccount> accounts;
        private AccountNrGenerator accountNrGenerator;
        private List<Transfer> failingTransfers;

        public Bank()
        {
            accountNrGenerator = new AccountNrGenerator();
            accounts = new Dictionary<string, BankAccount>();
            failingTransfers = new List<Transfer>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pin"></param>
        /// <returns>Returns the account number if successful, otherwise null.</returns>
        public string AddAccount(string pin)
        {
            return AddAccount(pin, 0);
        }
        public string AddAccount(string pin, int balance)
        {
            if (pin == "" || pin == null) return null;
            if (balance < 0) balance = 0;

            string accountNbr = accountNrGenerator.GetUniqieAccountNr();
            accounts.Add(accountNbr, new BankAccount(accountNbr, pin, balance));

            if (accounts.ContainsKey(accountNbr))
            {
                return accountNbr;
            }

            return null;
        }
        public int GetBalance(string accountNr, string pin)
        {
            BankAccount acc; 
            accounts.TryGetValue(accountNr, out acc);
            if (acc == null) return 0;
            if (acc.ValidatePin(pin))
            {
                return acc.Balance;
            }
            return 0;
        }
        /// <summary>
        /// Call to transfer will fail either pin is wrong or the amount is bigger than allowed.
        /// </summary>
        /// <param name="transfer"></param>
        /// <param name="pin"></param>
        /// <returns>True if successful.</returns>
        public bool Transfer(Transfer transfer, string pin)
        {
            BankAccount fromAcc;
            BankAccount toAcc;

            accounts.TryGetValue(transfer.FromAccountNr, out fromAcc);
            accounts.TryGetValue(transfer.ToAccountNr, out toAcc);

            if (fromAcc == null && toAcc == null)
            {
                failingTransfers.Add(transfer);
                return false;
            }
            if (fromAcc.ValidatePin(pin) == true)
            {
                return fromAcc.Transfer(transfer) && toAcc.Transfer(transfer);
            }
            failingTransfers.Add(transfer);
            return false;
        }

        public List<Transfer> GetTransfers(string accountNr, string pin)
        {
            BankAccount acc;
            accounts.TryGetValue(accountNr, out acc);
            if (acc == null || acc.ValidatePin(pin) == false)
            {
                return null;
            }
            List<Transfer> a = new List<Transfer>();
            a.AddRange(acc.GetTransfers());
            a.AddRange(failingTransfers);

            return a;
        }

        
    }
}
