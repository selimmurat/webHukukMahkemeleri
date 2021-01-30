using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UnitOpenFile:IEntity
    {
        public int Id { get; set; }
        public int unit_Id { get; set; }
        public int file_year { get; set; }
        public int file_no { get; set; }
        public int file_type_Id { get; set; }
        public int file_case_Id { get; set; }
        public int state_Id { get; set; }
        public int file_decision_Id { get; set; }
        public int decision_year { get; set; }
        public int decision_no { get; set; }
        public DateTime create_date { get; set; }
        public int create_employee_Id { get; set; }
        public int law_way_Id { get; set; }
        public int MyProperty { get; set; }
        public int istinaf_year { get; set; }
        public int istinaf_no { get; set; }
        public int temyiz_year { get; set; }
        public int temyiz_no { get; set; }
    }
}
