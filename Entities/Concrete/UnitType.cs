using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UnitType:IEntity
    {
        public int Id { get; set; }
        public int unit_area_id { get; set; }
        public string unit_type_name { get; set; }
    }
}
