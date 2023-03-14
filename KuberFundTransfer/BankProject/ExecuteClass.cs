using System;
using System.Collections.Generic;
using System.Text;

namespace KuberFundTransfer.BankProject
{
    public class ExecuteClass
    {


















































        static void Main(string[] args)
        {
            int option = 6;
            Crud crud = new Crud();
            do
            {
                Console.WriteLine("Login....");
                Console.WriteLine("Enter Username");
                AUser user = new AUser();            
                user.Username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();
                //Console.WriteLine("User is active or deactive");
                //user.IsActive = Boolean.Parse(Console.ReadLine());

                int result = crud.ValidateUser(user);
                if (result == 1)
                {
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Update User");
                    Console.WriteLine("3. Delete User");
                    Console.WriteLine("4. Activate User");
                    Console.WriteLine("5. Deactivate User");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter Option to proceed");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            AUser user1 = new AUser();
                            Console.WriteLine("Enter Username");
                            user1.Username = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            user.Password = Console.ReadLine();
                            crud.AddUser(user1);
                            option = 6;
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
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            break;

                        case 6:
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 2)
                {
                    option = 6;
                    Console.WriteLine("Invalid User Crediential ");
                }
            }
            while (option == 6);
        }
    }
}
