using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class District:IEntity
    {
        public int Id { get; set; }
        public int city_id { get; set; }
        public string district_name { get; set; }
    }
}
