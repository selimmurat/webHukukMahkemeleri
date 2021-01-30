using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileRegisterPerson:IEntity
    {
        public int Id { get; set; }
        public int file_Id { get; set; }
        public int person_Id { get; set; }
        public int adjective_Id { get; set; }
        public int lawyer_Id { get; set; }
        public string Active { get; set; }
    }
}
