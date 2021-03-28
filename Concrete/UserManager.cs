using CAGame.Abstract;
using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Concrete
{
    public class UserManager : IUserService

    {
        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " kullanıcı silindi. ");
        }

       

        public void Save(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " kullanıcı eklendi. ");
        }

       

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " kullanıcı güncellendi. ");
        }

        
    }
}
