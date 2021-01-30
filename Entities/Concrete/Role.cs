using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Role:IEntity
    {
        public int Id { get; set; }
        public string role_name { get; set; }
    }
}
