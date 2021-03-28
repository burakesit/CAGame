using CAGame.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
