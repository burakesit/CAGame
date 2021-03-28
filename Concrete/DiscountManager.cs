using CAGame.Abstract;
using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Concrete
{
    public class DiscountManager : IDiscountService

    {
        public void Add(Game game, Discount discount)
        {
            
            Console.WriteLine(game.GameName + " oyunun fiyatı " + game.GamePrice + " TL'dir.İndirim sonrası fiyat " + (game.GamePrice-((discount.DiscountRatio*game.GamePrice)/100)) + "TL'dir.");
            
        }

       
        public void Delete(Game game, Discount discount)
        {
            Console.WriteLine(game.GameName + " oyununun " + discount.DiscountRatio + "geçerli indirimi silindi");
        }

        public void Update(Game game, Discount discount)
        {
            Console.WriteLine(game.GameName + " oyununun " + discount.DiscountRatio + " oranında indirimi güncellendi.");
        }

       
    }
}
