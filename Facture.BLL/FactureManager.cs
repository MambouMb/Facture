using MC1.BO;
using MC1.DAL;
using System;

namespace Facture.BLL
{
    public class FactureManager
    {

        UserRepository userRepository;
        User user;
        public FactureManager()
        {
            userRepository = new UserRepository();
            user = new User();
        }


        public void AddUser(User user)
        {
            userRepository.Add(user);
        }

        









    }
}
