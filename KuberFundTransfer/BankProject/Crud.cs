using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.BankProject
{
    public class Crud
    {
         List<AUser> UserList = null;
        public static int count;

        public List<AUser> ShowAllUsers()
        {
            return UserList;
        }

      /*  public List<AUser> ShowActiveUsers()
        {
            List<AUser> UserList1 = new List<AUser>();
            foreach (AUser item in UserList)
            {
                if(item.IsActive==true)
                {
                    UserList1.Add(item);
                    break;
                }
            }
            return UserList1;
        }
        public List<AUser> ShowDeactiveUsers()
        {
            List<AUser> UserList2 = new List<AUser>();
            foreach (AUser item in UserList)
            {
                if(item.IsActive==false)
                {
                    UserList2.Add(item);
                    break;
                }
            }
            return UserList2;
        }*/
        public List<AUser> ShowCustomers()
        {
            List<AUser> UserList3 = new List<AUser>();
            foreach (AUser item in UserList)
            {
                if(item.Role==Roles.Customer)
                {
                    UserList3.Add(item);
                    break;
                }
            }
            return UserList3;
        }
        public Crud()
        {
            count++;
            UserList = new List<AUser>();
            UserList.Add(new AUser {  Username = "Admin", UserId = count, Password = "123" ,Role=Roles.Admin});
        }
        public void AddUser(AUser user)
        {
            user.Role = Roles.Customer;
          //  user.IsActive = true;
            count++;
            user.UserId = count;
            UserList.Add(user);
        }
        public void UpdateUser(AUser user)
        {
            foreach (AUser item in UserList)
            {
                if (item.UserId == user.UserId)
                {
                    item.Username = user.Username;
                    break;
                }
            }
        }
       /* public void DeactivateUser(AUser user)
        {
            foreach (AUser u in UserList)
            {
                if(u.UserId==user.UserId)
                {
                    u.IsActive = false;
                    break;
                }
            }
        }*/
       /* public void ActivateUser(AUser user)
        {
            foreach (AUser item in UserList)
            {
                if(item.UserId==user.UserId)
                {
                    item.IsActive = true;
                    break;
                }
            }
        }*/
       
        public void DeleteUser(int userid)
        {
            foreach (AUser item in UserList)
            {
                if(item.UserId==userid)
                {
                    UserList.Remove(item);
                    break;
                }
            }
        }

        public int ValidateUser(AUser user)
        {
            foreach (AUser u in UserList)
            {
                if(u.Username==user.Username && u.Password==user.Password )//&& u.IsActive==true)
                {
                    if( u.Role==Roles.Admin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 2;
        }
    }
}
