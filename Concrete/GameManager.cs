using CAGame.Abstract;
using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Concrete
{
    public class GameManager : IGameService

    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "oyununuz alınacaklar listesine eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "oyununuz alınacaklar listesinden silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "oyununun fiyatı güncellendi.");
        }
    }
}
