using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSoftware
{
    
    
    public static class AccountDB
    {
        public static void SeedData()
        {
            BackAccounts.Add(new Account("Avnish", 1000, "sdas asda", 94545, 41256985412));
            BackAccounts.Add(new Account("Meet", 1000, "sdas asda", 94545, 41256985413));

        }
        public static List<Account> BackAccounts= new List<Account>();
    }
}
