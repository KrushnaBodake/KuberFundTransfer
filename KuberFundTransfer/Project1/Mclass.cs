using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.Project
{
    public class Mclass
    {
        static void Main(string[] args)
        {
            int op = 6;
            UserCrud usercrud = new UserCrud();
            
            do
            {
                Console.WriteLine("Login");
                Console.WriteLine("Enter Username");
                User1 user = new User1();
                user.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();
               
                int result = usercrud.ValidateUser(user);
                if (result == 1)
                {
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Update User");
                    Console.WriteLine("3. Delete User");
                    Console.WriteLine("4. Activate User");
                    Console.WriteLine("5. Deactivate User");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter Option to proceed");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            User1 u = new User1();
                            Console.WriteLine("Enter Username");
                            u.UserName = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            u.Password = Console.ReadLine();
                            Console.WriteLine("Enter user initial balance");
                            u.UserBalance = Convert.ToDouble(Console.ReadLine());
                            usercrud.AddUser(u);
                            Console.WriteLine("User List");
                            List<User1> list = usercrud.ShowCustomer();
                            foreach (User1 item in list)
                            {
                                Console.WriteLine($"{item.UserId} {item.UserBalance} {item.UserName}  {item.Password}");
                            }
                            op = 6;
                            break;
                        case 2:
                            User1 u1 = new User1();
                            Console.WriteLine("Enter UserId to update");
                            u1.UserId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Username");
                            u1.UserName =Console.ReadLine();
                            Console.WriteLine("Enter new Password");
                            u1.Password = Console.ReadLine();
                            usercrud.UpdateUser(u1);
                            list = usercrud.ShowCustomer();
                            foreach (User1 item in list)
                            {
                                Console.WriteLine($"{item.UserId}  {item.UserBalance} {item.UserName}  {item.Password}");
                            }
                            op = 6;
                            break;
                        case 3:
                            User1 u2 = new User1();
                            Console.WriteLine("Enter id to delete user");
                            int userid = Convert.ToInt32(Console.ReadLine());
                            usercrud.DeleteUser(userid);
                            Console.WriteLine("Delete User Information");
                            list = usercrud.ShowCustomer();
                            foreach (User1 item in list)
                            {
                                Console.WriteLine($"{item.UserId}  {item.UserName}  {item.Password}");
                            }
                            op = 6;
                            break;
                        case 4:
                            User1 u3 = new User1();
                            Console.WriteLine("Enter id to Active User");
                            u3.UserId = Convert.ToInt32(Console.ReadLine());
                            usercrud.ActivateUser(u3);
                            op = 6;
                            break;
                        case 5:
                            User1 u4 = new User1();
                            Console.WriteLine("Enter userid to deactive User");
                            u4.UserId = Convert.ToInt32(Console.ReadLine());
                            usercrud.DeactivateUser(u4);
                            op = 6;
                            break;
                        case 6:
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 0)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Add payee");
                    Console.WriteLine("3. Remove Payee");
                    Console.WriteLine("4. Transfer Money");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter Option to proceed");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:

                            break;
                        case 2:
                           
                            PayeeClass1 p = new PayeeClass1();
                            Console.WriteLine("Enter UserId");
                            p.UserId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter--> Pyee name........Payee Acc No..........Payee Balance.");
                            p.PayeeName = Console.ReadLine();
                            p.PayeeAccNo = Convert.ToInt32(Console.ReadLine());
                            p.PayeeBalance = Convert.ToDouble(Console.ReadLine());
                            usercrud.AddPayee(p);
                            List<PayeeClass1> list1=usercrud.ShowAllPayees();
                            foreach (PayeeClass1 item in list1)
                            {
                                Console.WriteLine($"{item.UserId}  {item.PayeeName}  {item.PayeeAccNo}  {item.PayeeBalance}");
                            }                                                     
                            op = 6;
                            break;

                        case 3:
                            PayeeClass1 p2 = new PayeeClass1();
                            Console.WriteLine("Enter id to Remove");
                            int userid = Convert.ToInt32(Console.ReadLine());
                            usercrud.RemovePayee(userid);
                            Console.WriteLine("Delete Payee Information");
                            list1 = usercrud.ShowAllPayees();
                            foreach (PayeeClass1 item in list1)
                            {
                                Console.WriteLine($"{item.UserId}  {item.PayeeName}  {item.PayeeAccNo}  {item.PayeeBalance}");
                            }
                            op = 6;
                            break;
                        case 4:
                            Console.WriteLine("Enter id to transfer");
                            User1 u6 = new User1();
                            u6.UserId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Money to transfer");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            usercrud.UserTransfer(amount);
                            List<User1> list = usercrud.ShowAllUsers();
                            foreach (User1 item in list)
                            {
                                Console.WriteLine($"{item.UserId} updated Balance: {item.UserBalance} {item.UserName}  {item.Password}");
                            }
                            op = 6;
                            break;
                        case 6:
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if(result ==2)
                {
                    op = 6;
                    Console.WriteLine("Username and Password wrong");
                }
            } while (op == 6);

        }
    }
}
