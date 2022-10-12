namespace FDM.menu
{
    public class MM
    {
        public void MainMenu()
        {
            Console.WriteLine("Enter 1 as Admin\nEnter 2 as Chef\nEnter 3 as Delivery\nEnter 4 as Customer");
            int opt = int.Parse(Console.ReadLine());
            if(opt == 1)
            {
                AM am = new AM();
                am.AdminMenu();
            }

            else if(opt == 2)
            {

            }
            else if (opt == 3)
            {

            }
            else if (opt == 4)
            {

            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
        
    }
}