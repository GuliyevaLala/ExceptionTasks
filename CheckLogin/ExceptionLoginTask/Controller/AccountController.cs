using Domaiin.BaseEntity;
using Servicess.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLoginTask.Controller {
    public class AccountController {
        public static void Login()
        {
            try
            {
                AccountServices acc = new AccountServices();

                Console.WriteLine("Please enter your Username : ");

                string? username = Console.ReadLine();

                Console.WriteLine("Please enter your Email address : ");

                string? email = Console.ReadLine();

                Console.WriteLine("Please enter your Passcode : ");

                string? passcode = Console.ReadLine();

                var result = acc.CheckLogin(new User(username, email, passcode));

                if (result == true)
                {
                    Console.Clear();
                    Console.WriteLine("U have successfully Sign IN .");
                }
                else
                {
                    Console.WriteLine("Oppss!! Something went wrong!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}