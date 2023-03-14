using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.BankProject
{
    public class Account
    {
        public int UserId { get; set; }
        public int AccNo{ get; set; }
        public double Balance{ get; set; }
        public AcountTypes AcountType { get; set; }
    }
}
