using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Entity
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
