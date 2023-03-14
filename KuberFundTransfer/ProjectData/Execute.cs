using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.ProjectData
{
    public class Execute
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kuber Fund Transfer");
            UserTransaction user = new UserTransaction();

            Console.WriteLine("Enter UserId ");
            User u1 = new User();
            u1.UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserName");
            u1.UserName=Console.ReadLine();
            Console.WriteLine("Enter Password");
            u1.Password=(Console.ReadLine());
            Console.WriteLine( "User Acc Balance");
            u1.AccBalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Payee ID   Name   Balance");
            Payee p1 = new Payee();
            p1.PayeeId = Convert.ToInt32(Console.ReadLine());
            p1.PayeeName = Console.ReadLine();
            p1.PayeeAccountBal = Convert.ToDouble(Console.ReadLine());
            user.AddPayee(p1);


            /*Console.WriteLine("enter Payee ID   Name   Balance");
            Payee p2 = new Payee();
            p2.PayeeId = Convert.ToInt32(Console.ReadLine());
            p2.PayeeName = Console.ReadLine();
            p2.PayeeAccountBal = Convert.ToDouble(Console.ReadLine());
            user.AddPayee(p2);*/

            List<Payee> List2 = user.ListPayee();
            foreach (Payee item in List2)
            {
                Console.WriteLine($" payeeid {item.PayeeId}   payeename{item.PayeeName}  PayeeAccBalance{item.PayeeAccountBal}");
            }

            Console.WriteLine("Credit amount");
            double amt = Convert.ToDouble(Console.ReadLine());
            user.Credit(amt);
            List2 = user.ListPayee();
            foreach (Payee item in List2)
            {
                Console.WriteLine($" payeeid  {item.PayeeId}   payeename    {item.PayeeName}  PayeeAccBalance   {item.PayeeAccountBal}");
            }

            /* Console.WriteLine("Debit amount");
             double debitamt = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Select PayeeId to Debit Amount");
             int id = Convert.ToInt32(Console.ReadLine());
             user.Debit(debitamt,id);
             List2 = user.ListPayee();
             foreach (Payee item in List2)
             {
                 Console.WriteLine($" payeeid {item.PayeeId}   payeename{item.PayeeName}  PayeeAccBalance{item.PayeeAccountBal}");
             }*/

            Console.WriteLine("User Balance");
            Payee p3 = new Payee();
            
            List<User> List3 =user.ListUser();
            foreach (User item in List3)
            {
                Console.WriteLine($"  {item.UserId}   {item.UserName}  {item.AccBalance}");
            }

        }
    }
}
