using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);

    }
}
