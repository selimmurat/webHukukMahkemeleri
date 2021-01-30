using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        List<Employee> GetByTC_KimlikNo(string TC_KimlikNo);
        Employee GetBySicilNo(string sicilNo);
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);

    }
}
