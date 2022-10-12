namespace FDM
{
    // the solid principle******    

    public class Chef : User
    {
        public string ChefID { get; set; }
        public Chef(string firstName, string lastName, string email, int pin, string chefID) : base(firstName, lastName, email, pin)
        {
            ChefID = chefID;
            

        }
    }
}