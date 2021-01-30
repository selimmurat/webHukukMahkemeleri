using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeUnitRoleManager : IEmployeeUnitRoleService
    {
        private IEmployeeUnitRoleDAL _employeeUnitRoleDAL;

        public EmployeeUnitRoleManager(IEmployeeUnitRoleDAL employeeUnitRoleDAL)
        {
            _employeeUnitRoleDAL = employeeUnitRoleDAL;
        }

        public void Add(EmployeeUnitRole employeeUnitRole)
        {
            _employeeUnitRoleDAL.Add(employeeUnitRole);
        }

        public void Delete(EmployeeUnitRole employeeUnitRole)
        {
            _employeeUnitRoleDAL.Delete(employeeUnitRole);
        }

        public List<EmployeeUnitRole> GetAll()
        {
            return _employeeUnitRoleDAL.GetList().ToList();
        }

        public List<EmployeeUnitRoleDetailDTO> getUnitRoleDetailDTO(int employee_Id)
        {
            using (HelperContext context = new HelperContext())
            {
                var result = from e in context.t_gnl_employee

                             join eur in context.t_gnl_employee_unit_role on e.Id equals eur.employee_Id
                             join u in context.t_gnl_unit on eur.unit_Id equals u.Id
                             join r in context.t_gnl_role.DefaultIfEmpty() on eur.role_Id equals r.Id
                              

                             where e.Id == employee_Id
                             select new EmployeeUnitRoleDetailDTO
                             { employeeId = e.Id, UnitName = u.unit_name, role_name = r.role_name };

                return result.ToList();
            }
        }

        public void Update(EmployeeUnitRole employeeUnitRole)
        {
            _employeeUnitRoleDAL.Update(employeeUnitRole);
        }
    }
}
