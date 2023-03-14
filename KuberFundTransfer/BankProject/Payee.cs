using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.BankProject
{
    public class Payee
    {
        public int UserId{ get; set; }
        public String PayeeName{ get; set; }
        public int PayeeAccNo { get; set; }
        public double PayeeBalance { get; set; }
        public double Amount { get; set; }
    }
}
