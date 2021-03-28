using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Entity
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public int NewGamePrice { get; set; }


    }
}
