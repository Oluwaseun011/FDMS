using FDM.implementation;
using FDM.interfaces;

namespace FDM.menu
{
    public class AM
    {
        IAdminManager adminManager = new AdminManager();

        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to register\nEnter 2 to login");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                RegisterAdminMenu();
            }
            else if(choice == 2)
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        public void RegisterAdminMenu()
        {
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();

            adminManager.CreateAdmin(fName, lName, email, pin, post);
            AdminMenu();
        }

        public void LoginMenu()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your pin: ");
            int pin = int.Parse(Console.ReadLine());
            Admin ad = adminManager.Login(email, pin);
            if(ad != null)
            {
                Console.WriteLine("login successful");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine("wrong email or pin");
            }

        }

        public void AdminSubMenu()
        {
            Console.WriteLine("Enter 1 to register food\nEnter 2 to update food");
        }
    }
}