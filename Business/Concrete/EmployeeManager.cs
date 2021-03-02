using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDAL _employeeDal;
        HelperContext c = new HelperContext();


        public EmployeeManager(IEmployeeDAL employeeDal)
        {
            _employeeDal = employeeDal;
        }

        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Add(Employee employee)
        {
            //business kodları gelecek 

            emp.TC_KimlikNo = employee.Name;
            emp.sicil_no = employee.sicil_no;
            emp.Name = employee.Name;
            emp.SurName = employee.SurName;
            emp.Email = employee.Email;*/
            _employeeDal.Add(employee);
            return new SuccessResult("Personel ekleme işlemi başarılı");
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new Result(true, "Personel Silinmiştir.");
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList().ToList(), "Tüm Personeller Listelendi.");
        }

        public IDataResult<Employee> GetById(int Id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e => e.Id == Id));
        }

        public IDataResult<Employee> GetBySicilNo(string sicilNo)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e => e.sicil_no == sicilNo));
        }

        public IDataResult<List<Employee>> GetByTC_KimlikNo(string TC_KimlikNo)
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList(e => e.TC_KimlikNo == TC_KimlikNo).ToList());
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new Result(true, "Personel bilgileri güncellenmiştir.");
        }
    }
}
