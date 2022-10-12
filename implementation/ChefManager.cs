using FDM.interfaces;
namespace FDM.implementation
{
    public class ChefManager : IChefManager
    {
        public bool ICreateChef(string firstName, string lastName, string email, string pin)
        {
            throw new NotImplementedException();
        }

        public void IDeleteChef(Chef chef)
        {
            throw new NotImplementedException();
        }

        public Chef IGetChef(string email)
        {
            throw new NotImplementedException();
        }

        public void IUpdateChef(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }

}