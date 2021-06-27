using System;


namespace OnlineShoppingBL
{
    public class UserManagementBL
    {
        public string userNameInput, userPasswordInput, oldUserName = "user1", oldUserPassword = "qwerty",
            newUserName, newUserPassword, newUserAddress;
       
        public void SignIn()
        {          
            Console.WriteLine("Please Fill in the Informations Needed");
            Console.Write("Username: ");
            newUserName = Console.ReadLine();
            Console.Write("Password: ");
            newUserPassword = Console.ReadLine();
            Console.Write("Address: ");
            newUserAddress = Console.ReadLine();
            Console.WriteLine("Account has been created");

        }
        public void LogIn()
        {
            Console.WriteLine("Please Enter Your Username & Password");
            Console.Write("Username: ");
            userNameInput = Console.ReadLine();
            Console.Write("Password: ");
            userPasswordInput = Console.ReadLine();

            if (oldUserName.Equals(userNameInput) && oldUserPassword.Equals(userPasswordInput))
            {
                Console.WriteLine("Welcome " + userNameInput);
                OrderBL displaycategories = new OrderBL();
                displaycategories.DisplayCategories();

                OrderBL order = new OrderBL();
                order.Order();

            }
            else if (userNameInput.Equals("") || userPasswordInput.Equals(""))
            {
                Console.WriteLine("Please Enter a Username or Password");
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
            }
            
        }
       
    }
}
