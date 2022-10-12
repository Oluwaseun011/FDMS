using FDM.models;
namespace FDM.interfaces
{
    public interface IChefManager
    {

        public bool ICreateChef(string firstName, string lastName, string email, string pin);
        public void IUpdateChef(string firstName, string lastName);
        public void IDeleteChef(Chef chef);
        public Chef IGetChef(string email);

    }
}