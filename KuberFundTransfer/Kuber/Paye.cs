using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Kuber
{
    public class Paye
    {
        public int PayeeId { get; set; }
        public int UserId { get; set; }
        public string PayeeName { get; set; }
        public int PayeeAccNo { get; set; }
        public double PayeeBalance { get; set; }
        public override string ToString()
        {
            return $"Payee id:{PayeeId} Payee name:{PayeeName} Balance:{PayeeBalance}";
        }
    }
}
