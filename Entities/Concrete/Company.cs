using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Company:IEntity
    {
        public int Id { get; set; }
        public int mersis_no { get; set; }
        public int vergi_no { get; set; }
        public string company_name { get; set; }
    }
}
