using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileCaseType:IEntity
    {
        public int Id { get; set; }
        public int file_Id { get; set; }
        public int case_Id { get; set; }
    }
}
