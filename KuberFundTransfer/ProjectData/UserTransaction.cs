using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.ProjectData
{

    public class UserTransaction : Payee
    {

        private List<User> Userlist = null;
        private List<Payee> Payeelist = new List<Payee>();
        public UserTransaction()
        {
            Userlist = new List<User>();
            Payeelist = new List<Payee>();
        }

        public void Passward(User pass)
        {
            Userlist.Add(pass);
        }
        public void AddUser(User user)
        {
            Userlist.Add(user);
             
        }
        public void RemoveUser(int userid)
        {
            foreach (User item in Userlist)
            {
                if (item.UserId == userid)
                {
                    Userlist.Remove(item);
                    break;
                }
            }           
        }
       
        public void Credit(double amt)
        {
           
            foreach (Payee item in Payeelist)
            {
                item.PayeeAccountBal = item.PayeeAccountBal + amt;
             //   AccBalance = AccBalance - amt;
                break;
            }
           
         
        }
        public List<User> UserDebit(Payee payee)
        {
            List<User> UserList1 = new List<User>();
            foreach (User item in Userlist)
            {
                item.AccBalance = item.AccBalance - PayeeAccountBal;
                UserList1.Add(item);
                break;
            }
            return UserList1;
        }
       
        public void Debit(double debitamt, int id)
        {
            foreach (Payee item in Payeelist)
            {
                if(item.PayeeId==id)
                item.PayeeAccountBal = item.PayeeAccountBal - debitamt;
                break;
            }

        }
       

        public void AddPayee(Payee payee)
        {
            Payeelist.Add(payee);
        }
        public void RemovePayee(int payeeid)
        {
            foreach (Payee item in Payeelist)
            {
                if(item.PayeeId==payeeid)
                {
                    Payeelist.Remove(item);
                    break;
                }
            }
        }
       
        public double AddAmount(double amount)
        {
            return amount;
        }
        public List<Payee> ListPayee()
        {
            return Payeelist;
        }  
        public List<User> ListUser()
        {
            return Userlist;
        }
            
        
    }
}
