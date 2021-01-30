using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DecisionType:IEntity
    {
        public int Id { get; set; }
        public string decision_name { get; set; }
    }
}
