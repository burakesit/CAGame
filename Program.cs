using System;
using CAGame.Abstract;
using CAGame.Concrete;
using CAGame.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAGame.Entity;

namespace CAGame
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User {Id =1,TcNo="5083694781", FirstName="Ali",LastName="Veli",BirthYear=new DateTime(1998 / 5 /12) };
            User user2 = new User {Id =2, TcNo = "5078412581", FirstName ="Kemal",LastName="Alemdar",BirthYear=new DateTime(1991 / 21 /12) };
            User user3 = new User {Id =3, TcNo = "50902571290", FirstName ="Burak",LastName="Eşit",BirthYear=new DateTime(1994 / 16 /16) };
            User user4 = new User {Id =4, TcNo = "5076841990", FirstName ="Murat",LastName="Kaldırım",BirthYear=new DateTime(1997 / 1 /1) };

            UserManager userManager = new UserManager();
            userManager.Save(user1);

            Game game1 = new Game { Id = 1, GameName = "Player Unknown's Battlegrounds", GamePrice = 70 };
            Game game2 = new Game { Id = 2, GameName = "CS : Go", GamePrice = 16 };
            Game game3 = new Game { Id = 3, GameName = "Scare", GamePrice = 5 };

            

            Discount discount1 = new Discount { Id=1,DiscountName="Ocak Söndüren İndirimler",DiscountRatio=10};
            Discount discount2 = new Discount { Id=2,DiscountName="Ev Şenlendiren İndirimler",DiscountRatio=80};


            DiscountManager discountManager = new DiscountManager();
            discountManager.Add(game2, discount2);

            Sales sales1 = new Sales { Id = 1, SaleDate = DateTime.Now };

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(user1, game2, discount2, sales1);

            ILoggerService fileLoggerService = new FileLogger ();
            ILoggerService databaseLoggerService = new DatabaseLogger ();
            fileLoggerService.Log();

            Console.ReadLine();



        }
    }
}
