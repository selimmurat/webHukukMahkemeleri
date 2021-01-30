using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileType:IEntity
    {
        public int Id { get; set; }
        public string file_type_name { get; set; }
    }
}
