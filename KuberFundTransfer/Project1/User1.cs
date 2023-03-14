using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Project
{
    public enum Roles { Admin=1, Customer=2}
    public  class User1
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public double UserBalance { get; set; }
        public bool IsActive { get; set; }
        public Roles Role { get; set; }

    }
}
