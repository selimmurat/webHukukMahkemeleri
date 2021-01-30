using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Unit:IEntity
    {
        public int Id { get; set; }
        public int unit_code { get; set; }
        public int unit_type_id { get; set; }
        public string unit_name { get; set; }
        public int city_id { get; set; }
    }
}
