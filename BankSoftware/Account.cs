using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSoftware
{
    public class Account
    {
        public string Name;
        public int OpBalance;
        public string Address;
        public long Phone;
        public long Accn;
        public Account(string n, int ob, string add, long pno, long acc)
        {
            Name = n;
            OpBalance = ob;
            Address = add;
            Phone = pno;
            Accn = acc;
        }
    }
}
