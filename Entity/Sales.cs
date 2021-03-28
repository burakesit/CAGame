using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Entity
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
