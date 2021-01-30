using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string TC_KimlikNo { get; set; }
        public string sicil_no { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
    }
}
