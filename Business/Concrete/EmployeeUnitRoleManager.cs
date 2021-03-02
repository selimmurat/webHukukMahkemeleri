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

                                  where eur.employee_Id == employeeId
                                  select new
                                  {
                                      #region employee tablosu 
                                      eur.employee_Id,
                                      e.TC_KimlikNo,
                                      e.sicil_no,
                                      e.Name,
                                      e.SurName,
                                      e.Email,
                                      #endregion
                                      #region Unit tablosu
                                      u.Id,
                                      u.unit_code,
                                      u.unit_name,
                                      #endregion
                                      #region Unit Area tablosu
                                      t.unit_area_id,
                                      a.unit_area_name,
                                      #endregion
                                      #region Unit type tablosu
                                      u.unit_type_id,
                                      t.unit_type_name,
                                      #endregion
                                      #region City
                                      u.city_id,
                                      c.city_name,
                                      #endregion
                                      #region Role
                                      eur.role_Id,
                                      r.role_name,
                                      #endregion
                                      #region District
                                      d.district_name
                                      #endregion

                             where e.Id == employee_Id
                             select new EmployeeUnitRoleDetailDTO
                             { employeeId = e.Id, UnitName = u.unit_name, role_name = r.role_name };

                return result.ToList();
            }
            return dto;
        }

        public void Update(EmployeeUnitRole employeeUnitRole)
        {
            _employeeUnitRoleDAL.Update(employeeUnitRole);
        }
    }
}
