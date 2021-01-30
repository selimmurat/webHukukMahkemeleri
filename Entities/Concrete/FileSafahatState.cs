using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileSafahatState:IEntity
    {
        public int Id { get; set; }
        public int file_Id { get; set; }
        public int employee_Id { get; set; }
        public int unit_Id { get; set; }
        public string stament { get; set; }
    }
}
