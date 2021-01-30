using Business.Abstract;
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

        public void Add(Employee employee)
        {
            /*Employee emp = new Employee();

            emp.TC_KimlikNo = employee.Name;
            emp.sicil_no = employee.sicil_no;
            emp.Name = employee.Name;
            emp.SurName = employee.SurName;
            emp.Email = employee.Email;*/
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
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

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
