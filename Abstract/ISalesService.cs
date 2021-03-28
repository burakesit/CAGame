using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Abstract
{
    public interface ISalesService
    {
        void Buy(User user, Game game, Discount discount, Sales sales);
        void Return(User user, Game game, Sales sales);
    }
}
