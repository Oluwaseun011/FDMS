namespace FDM
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public string Post { get; set; }
        public Admin (string firstName, string lastName, string email, int pin, int adminID, string post) : base(firstName, lastName, email, pin)
        {
            AdminID = adminID;
            Post = post;
        }

    }
}
