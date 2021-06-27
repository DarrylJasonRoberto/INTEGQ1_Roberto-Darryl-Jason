using System;
using OnlineShoppingBL;
namespace OnlineShoppingUI
{
    public class UI
    {
        public static string optionSelected;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Online Shop!!");
            Console.WriteLine("Do you have an existing account?");
            Console.WriteLine("Press Y/y if Yes or N/n if None");
            optionSelected = Console.ReadLine().ToLower();
            if (optionSelected.Equals("y"))
            {
                UserManagementBL login = new UserManagementBL();
                login.LogIn();
            }
            else if (optionSelected.Equals("n"))
            {
                UserManagementBL signin = new UserManagementBL();
                signin.SignIn();

                OrderBL displaycategories = new OrderBL();
                displaycategories.DisplayCategories();

                OrderBL order = new OrderBL();
                order.Order();
            }
              else
            {
                Console.WriteLine("Invalid keyword please try again");
            }

        }

    }
}

