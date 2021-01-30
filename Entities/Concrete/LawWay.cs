using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class LawWay:IEntity
    {
        public int Id { get; set; }
        public string law_way_name { get; set; }
    }
}
