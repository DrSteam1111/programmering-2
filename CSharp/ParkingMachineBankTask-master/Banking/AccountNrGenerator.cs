using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class AccountNrGenerator
    {
        private List<int> accountNrs = new List<int>() { 1000 };
        private int index = 0;

        public string GetUniqieAccountNr()
        {
            accountNrs.Add((accountNrs[index] + 1));
            index++;
            return accountNrs[index].ToString();
        }
    }
}
