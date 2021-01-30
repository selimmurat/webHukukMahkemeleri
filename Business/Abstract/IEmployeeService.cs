using Core.Utilities.Result;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        IDataResult<Employee> GetById(int Id);
        IDataResult<List<Employee>> GetByTC_KimlikNo(string TC_KimlikNo);
        IDataResult<Employee> GetBySicilNo(string sicilNo);
        IResult Add(Employee employee);
        IResult Delete(Employee employee);
        IResult Update(Employee employee);

    }
}
