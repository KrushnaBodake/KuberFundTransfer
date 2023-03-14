using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Project
{
    public class UserCrud 
    {
        List<User1> UserList = null;
        List<PayeeClass1> PayeeList = new List<PayeeClass1>();
        public static int count;
        
        public UserCrud()
        {
            PayeeList = new List<PayeeClass1>();
            count++;
            UserList = new List<User1>();           
            UserList.Add(new User1 { UserName = "admin", UserId = count,  Password = "123",  Role = Roles.Admin });
        }
        public void AddUser(User1 user)
        {
            user.Role = Roles.Customer;
            user.IsActive = true;
            count++;
            user.UserId = count;
            UserList.Add(user);
        }
        public void AddPayee(PayeeClass1 payee)
        {
             PayeeList.Add(payee);
        }
        public void ActivateUser(User1 user)
        {
            foreach (User1 item in UserList)
            {
                if(item.UserId==user.UserId)
                {
                    item.IsActive = true;
                    break;
                }
            }
        }
        public void DepositBal(User1 user)
        {

            foreach (User1 u in UserList)
            {
                if (u.UserId == user.UserId)
                {
                    u.UserBalance = u.UserBalance + user.UserBalance;


                }
            }
        }

        public void DeactivateUser(User1 user)
        {
            foreach (User1 u in UserList)
            {
                if (u.UserId == user.UserId)
                {
                    u.IsActive = false;
                    break;
                }
            }
        }
        public void UpdateUser(User1 user)
        {
            foreach (User1 item in UserList)
            {
                if (item.UserId == user.UserId)
                {
                    item.UserName = user.UserName;
                    item.Password = user.Password;
                    break;
                }
            }
        }
        public void DeleteUser(int userid)
        {
            foreach (User1 item in UserList)
            {
                if (item.UserId == userid)
                {
                    UserList.Remove(item);
                    break;
                }
            }
        }
        public void UserTransfer(double amount)
        {           
            foreach (User1 item in UserList)
            {
               item.UserBalance = item.UserBalance - amount;
               // Console.WriteLine(item.UserBalance);
                break;               
            }         
        }
       
        public void RemovePayee(int userid)
        {
            foreach (PayeeClass1 item in PayeeList)
            {
                if (item.UserId == userid)
                {
                    PayeeList.Remove(item);
                    break;
                }
            }
        }
        public List<User1> ShowAllUsers()
        {           
            return UserList;
        }
        public List<User1> ShowCustomer()
        {
            List<User1> list = new List<User1>();
            foreach (User1 item in list)
            {
                if(item.Role==Roles.Customer)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<PayeeClass1> ShowAllPayees()
        {
            return PayeeList;
        }
        public int ValidateUser(User1 user)
        {
            foreach ( User1 u in UserList)
            {
                if(u.UserName==user.UserName && u.Password==user.Password)
                {
                    if(u.Role==Roles.Admin)
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
