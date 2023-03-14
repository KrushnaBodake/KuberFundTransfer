using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.ProjectData
{
    public enum Role { Admin,User}
    public class User
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public double AccBalance { get; set; }
        public String Password { get; set; }

        public Role role { get; set; }

    }
}
