using FDM.interfaces;

namespace FDM.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmins = new List<Admin>();

        public void CreateAdmin(string firstName, string lastName, string email, int pin, string post)
        {
            Random rand = new Random();
            int adminID =rand.Next(10,99);
            Admin admin = new Admin(firstName, lastName, email, pin, adminID, post);
            listOfAdmins.Add(admin);
            Console.WriteLine("created succesfully");
        }

        public void DeleteAdmin(string email)
        {
            foreach (var item in listOfAdmins)
            {
                if(item.Email == email)
                {
                    listOfAdmins.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted succesfully");
        }

        public Admin GetAdmin(string email)
        {
            foreach (var item in listOfAdmins)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in listOfAdmins)
            {
                if(item.Email == email && item.PIN == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(string email,string firstName, string lastName, string post)
        {
            Admin adminToUpdate = GetAdmin(email);
            if(adminToUpdate != null)
            {
                adminToUpdate.FirstName = firstName;
                adminToUpdate.LastName = lastName;
                adminToUpdate.Post = post;
                Console.WriteLine("admin updated successfully");
            }
            else
            {
                Console.WriteLine("admin not found");
            }
        }
    }

}