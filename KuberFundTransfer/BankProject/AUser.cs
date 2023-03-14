using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.BankProject
{
    public enum Roles { Admin=1, Customer=2}
    public enum AcountTypes { Saving=1,Current=2}
    public class AUser
    {
        public int UserId{ get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
        public Roles Role { get; set; }
        //public bool IsActive{ get; set; }
    }
}
