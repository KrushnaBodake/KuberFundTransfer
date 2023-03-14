using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Project
{
    public enum AccountTypes { Saving, Current }
    public class AccountClass
    {
        public int UserId { get; set; }
        public int AccNo { get; set; }
        public double Balance { get; set; }
        public AccountTypes AccountType { get; set; }
    }
}
