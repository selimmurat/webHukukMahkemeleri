using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UnitDetailDto:IDto
    {
        public int unitId { get; set; }
        public int unit_code { get; set; }        
        public string unit_name { get; set; }
       
        
        public string unit_area_name { get; set; }
        public string unit_type_name { get; set; }

        public int city_Id { get; set; }
        public int unit_type_Id { get; set; }
        public int unit_area_Id { get; set; }

    }
}
