using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CaseType:IEntity
    {
        public int Id { get; set; }
        public int unit_type_Id { get; set; }
        public string case_name { get; set; }

    }
}
