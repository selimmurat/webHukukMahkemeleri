using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public string TC_NO { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
