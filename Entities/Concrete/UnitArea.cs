using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UnitArea:IEntity
    {
        public int Id { get; set; }
        public string unit_area_name { get; set; }
    }
}
