using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Lawyer:IEntity
    {
        public int Id { get; set; }
        public string sicil_no { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
