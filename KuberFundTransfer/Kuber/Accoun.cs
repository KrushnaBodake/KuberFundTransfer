using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Kuber
{
    public enum AccountTypes
    {
        Saving, Current
    }
    class Accoun
    {
        public int UserId { get; set; }
        public int AccNo { get; set; }

        public double Balance { get; set; }
        public AccountTypes AccountType { get; set; }

    }
}
