using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Abstract
{
    public interface IDiscountService:IEntity
    {
        void Add(Game game, Discount discount);
        void Update(Game game, Discount discount);
        void Delete(Game game, Discount discount);

        
    }
}
