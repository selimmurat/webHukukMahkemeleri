using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FileUnderConnection:IEntity
    {
        public int Id { get; set; }
        public int file_Id { get; set; }
        public int file_under_Id { get; set; }
        public int why_file_under_Id { get; set; }
        public DateTime create_date { get; set; }
    }
}
