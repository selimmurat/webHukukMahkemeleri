using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int Id);
        List<Employee> GetByTC_KimlikNo(string TC_KimlikNo);
        Employee GetBySicilNo(string sicilNo);
        IResult Add(Employee employee);
        IResult Delete(Employee employee);
        IResult Update(Employee employee);

    }
}
