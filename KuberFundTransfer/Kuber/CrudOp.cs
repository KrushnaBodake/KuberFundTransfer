using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Kuber
{
    public class CrudOp
    {
        public List<Userr> userList = new List<Userr>();
        public List<Paye> payeeList = new List<Paye>();
        public static int count;

        public List<Userr> ShowAll()
        {
            return userList;
        }
        public List<Userr> ShowCustomers()
        {
            List<Userr> list1 = new List<Userr>();
            foreach (Userr item in userList)
            {
                if (item.Role == Roles.Customer)
                {
                    list1.Add(item);
                }
            }
            return list1;
        }
        public List<Userr> ShowActiveUsers()
        {
            List<Userr> list = new List<Userr>();
            foreach (Userr item in userList)
            {
                if (item.IsActive == true)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<Userr> ShowDeactivedUsers()
        {
            List<Userr> list = new List<Userr>();
            foreach (Userr item in userList)
            {
                if (item.IsActive == false)
                {
                    list.Add(item);
                }
            }
            return list;
        }


        public void AddUser(Userr user)
        {
            user.Role = Roles.Customer;  // checks
            user.IsActive = true;
            user.UserId = user.UserId;
            userList.Add(user);
            count++;
        }
        public void DeactivateUser(Userr user)
        {
            foreach (var item in userList)
            {
                if (item.UserId == user.UserId)
                {
                    item.IsActive = false;
                    break;
                }
            }
        }
        public void ActivateUser(Userr user)
        {
            foreach (var item in userList)
            {
                if (item.UserId == user.UserId)
                {
                    item.IsActive = true;
                    break;
                }
            }
        }
        public CrudOp()
        {

            userList.Add(new Userr { UserName = "arun", UserId = 100, Password = "123", Role = Roles.Admin });
        }
        public int ValidateUser(Userr user, out int userid)
        {
            userid = 0;
            foreach (Userr u in userList)
            {
                if (u.UserName == user.UserName && user.Password == u.Password)
                {
                    if (u.Role == Roles.Admin)
                    {
                        userid = u.UserId;
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
        Userr u = new Userr();
        public double CheckBalance(Userr u2)
        {
            double b = 0;

            foreach (Userr u in userList)
            {
                if (u.UserId == u2.UserId)
                {
                    b = u.Balance + u.MinBalance;
                }
            }
            return b;

        }
        public void DepositBalance(Userr u4)
        {

            foreach (Userr u in userList)
            {
                if (u.UserId == u4.UserId)
                {
                    u.Balance = u.Balance + u4.Balance;


                }
            }
        }
        public void ModifyUser(Userr um)
        {
            //List<User> apdateList = new List<User>();
            foreach (Userr u in userList)
            {
                if (u.UserId == um.UserId)
                {
                    u.UserName = um.UserName;
                    u.Password = um.Password;
                    u.Role = um.Role;
                    u.MinBalance = um.MinBalance;
                }
            }

        }
        public void DeletUser(Userr um)
        {
            //List<User> apdateList = new List<User>();
            foreach (Userr u in userList)
            {
                if (u.UserId == um.UserId)
                {
                    userList.Remove(u);
                    break;
                }
            }

        }
        public void ShowActiveUser()
        {
            foreach (var item in userList)
            {
                if (item.IsActive == true)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void ShowDeActiveUser()
        {
            foreach (var item in userList)
            {
                if (item.IsActive == false)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void AddPayee(Paye p)
        {
            foreach (Userr item in userList)
            {
                if (item.UserId == p.UserId)
                {
                    if (item.IsActive == true)
                    {
                        payeeList.Add(p);
                    }
                    else
                    {
                        Console.WriteLine("Sorry you are InActive so yo can't Add Payee");
                    }
                }

            }

        }
        public void ShowPayeeList(int userid)
        {
            foreach (Paye p in payeeList)
            {
                if (p.UserId == userid)
                {
                    Console.WriteLine(p);
                }
            }
            
        }
        public void TransferMoney(Paye p, Userr u)
        {
            foreach (Userr ur in userList)
            {
                if (ur.UserId == u.UserId)
                {
                    if (ur.Balance < u.Balance)
                    {
                        throw new MinimunBalanceException("Your Balance is Less than Transfer Amount..");
                    }
                    else
                    {
                        foreach (Paye item in payeeList)
                        {
                            if (item.PayeeId == p.PayeeId)
                            {
                                item.PayeeBalance = item.PayeeBalance + u.Balance;
                            }

                        }
                        foreach (Userr item in userList)
                        {
                            if (item.UserId == u.UserId)
                            {
                                item.Balance = item.Balance - u.Balance;
                            }

                        }

                    }
                }

            }

        }
        public void DeletPayee(Paye p1,int userid)
        {

            foreach (Paye p in payeeList)
            {
                if (p.PayeeId == p1.PayeeId)
                {
                    payeeList.Remove(p);
                    break;
                }
            }

        }
    }
}

