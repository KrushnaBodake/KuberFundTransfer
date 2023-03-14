using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Kuber
{
    public class OnlyException
    {

    }
    public class MinimunBalanceException : Exception
    {
        public MinimunBalanceException(string msg) : base(msg)
        {

        }
    }
}
