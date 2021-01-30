using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeUnitRoleService
    {
        List<EmployeeUnitRole> GetAll();
        List<EmployeeUnitRoleDetailDTO> getUnitRoleDetailDTO(int employee_Id);
        void Add(EmployeeUnitRole employeeUnitRole);
        void Delete(EmployeeUnitRole employeeUnitRole);
        void Update(EmployeeUnitRole employeeUnitRole);

        #region deneme aşamasında
        /*EmployeeUnitRole GetById(int id);
       // List<EmployeeUnitRole> GetByUnitId(int id);

       List<EmployeeUnitRole> GetByRoleId(int id);*/
        #endregion


    }
}
