using CAGame.Abstract;
using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Buy(User user, Game game, Discount discount, Sales sales)
        {
            
            Console.WriteLine(user.FirstName + " " + user.LastName + " oyuncumuz "+ sales.SaleDate + " tarihinde " + game.GamePrice + " TL tutarındaki " + game.GameName + " oyununu yüzde " + discount.DiscountRatio + " indirimle " + (game.GamePrice - ((discount.DiscountRatio * game.GamePrice) / 100)) + " Tl ye satın aldı.");
        }

        public void Return(User user, Game game, Sales sales)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " oyuncumuz " + sales.SaleDate + " tarihinde " + game.GamePrice + " TL tutarındaki " + game.GameName + " oyununu iade etti." );
        }
    }
}
