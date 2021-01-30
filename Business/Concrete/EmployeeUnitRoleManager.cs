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

        public EmployeeUnitRoleDetailDTO GetByEmployeeId(int employeeId)
        {
            EmployeeUnitRoleDetailDTO dto = new EmployeeUnitRoleDetailDTO();

            if (_employeeUnitRoleDAL.Get(e => e.employee_Id == employeeId) == null)
            {
                using (var Context = new HelperContext())
                {
                    var result = (from u in Context.t_gnl_unit

                                  join eur in Context.t_gnl_employee_unit_role on u.Id equals eur.unit_Id
                                  join e in Context.t_gnl_employee on eur.employee_Id equals e.Id
                                  join r in Context.t_gnl_role on eur.role_Id equals r.Id
                                  join t in Context.t_gnl_unit_type on u.unit_type_id equals t.Id
                                  join a in Context.t_gnl_unit_area on t.unit_area_id equals a.Id
                                  join c in Context.t_gnl_city on u.city_id equals c.Id
                                  join d in Context.t_gnl_district on c.Id equals d.city_id

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

                                  }).ToList();

                    foreach (var item in result)
                    {
                        dto.employeeId = item.employee_Id;
                        dto.TC_KimlikNo = item.TC_KimlikNo;
                        dto.sicil_no = item.sicil_no;
                        dto.Name = item.Name;
                        dto.SurName = item.SurName;
                        dto.Email = item.Email;
                        dto.UnitId = item.Id;
                        dto.unit_code = item.unit_code;
                        dto.UnitName = item.unit_name;
                        dto.unit_type_id = item.unit_type_id;
                        dto.unit_type_name = item.unit_type_name;
                        dto.unit_area_id = item.unit_area_id;
                        dto.unit_area_name = item.unit_area_name;
                        dto.role_id = item.role_Id;
                        dto.role_name = item.role_name;
                        dto.city_id = item.city_id;
                        dto.city_name = item.city_name;
                        dto.district_name = item.district_name;
                    }
                }
            }
            return dto;
        }

        public void Update(EmployeeUnitRole employeeUnitRole)
        {
            _employeeUnitRoleDAL.Update(employeeUnitRole);
        }
    }
}
