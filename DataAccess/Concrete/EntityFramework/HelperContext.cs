using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class HelperContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DemoUyap;Trusted_Connection=true");
        }

        public DbSet<Adjective> t_gnl_adjective { get; set; }
        public DbSet<City> t_gnl_city { get; set; }
        public DbSet<Employee> t_gnl_employee { get; set; }
        public DbSet<UnitArea> t_gnl_unit_area { get; set; }
        public DbSet<CaseType> t_gnl_case_type { get; set; }
        public DbSet<Unit> t_gnl_unit { get; set; }
        public DbSet<UnitType> t_gnl_unit_type { get; set; }
        public DbSet<Company> t_gnl_company { get; set; }
        public DbSet<DecisionType> t_gnl_decision_type { get; set; }
        public DbSet<District> t_gnl_district { get; set; }
        public DbSet<EmployeeUnitRole> t_gnl_employee_unit_role { get; set; }
        public DbSet<Role> t_gnl_role { get; set; }
        public DbSet<FileStateType> t_gnl_file_state_type { get; set; }
        public DbSet<FileType> t_gnl_file_type { get; set; }
        public DbSet<LawWay> t_gnl_law_way { get; set; }
        public DbSet<Lawyer> t_gnl_lawyer { get; set; }
        public DbSet<UnitOpenFile> t_gnl_unit_open_file { get; set; }
        public DbSet<UnitEndProcessRowNumber> t_gnl_unit_end_process_row_number { get; set; }
        public DbSet<Person> t_gnl_person { get; set; }
        public DbSet<FileRegisterCompany> t_gnl_file_register_company { get; set; }
        public DbSet<FileRegisterPerson> t_gnl_file_register_person { get; set; }
        public DbSet<FileSafahatState> t_gnl_file_safahat_state { get; set; }
        public DbSet<FileUnderConnection> t_gnl_file_under_connection { get; set; }
        public DbSet<FileCaseType> t_gnl_file_case_type { get; set; }

    }

}
