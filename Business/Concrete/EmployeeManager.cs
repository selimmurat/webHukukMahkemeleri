using Business.Abstract;
using Core.Utilities.Result;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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

        public IResult Add(Employee employee)
        {
            if (employee.TC_KimlikNo != null)
            {
                return new ErrorResult("T.C. Kimlik numarası boş bırakılamaz.");
            }
            _employeeDal.Add(employee);
            return new SuccessResult("Personel ekleme işlemi başarılı");
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new Result(true, "Personel Silinmiştir.");
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList().ToList();
        }

        public Employee GetById(int Id)
        {
            return _employeeDal.Get(e => e.Id == Id);
        }

        public Employee GetBySicilNo(string sicilNo)
        {
            return _employeeDal.Get(e => e.sicil_no == sicilNo);
        }

        public List<Employee> GetByTC_KimlikNo(string TC_KimlikNo)
        {
            return _employeeDal.GetList(e => e.TC_KimlikNo == TC_KimlikNo).ToList();
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new Result(true, "Personel bilgileri güncellenmiştir.");
        }
    }
}
