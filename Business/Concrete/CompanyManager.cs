using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDAL _companyDAL;

        public CompanyManager(ICompanyDAL companyDAL)
        {
            _companyDAL = companyDAL;
        }

        public void Add(Company company)
        {
            _companyDAL.Add(company);
        }

        public void Delete(Company company)
        {
            _companyDAL.Delete(company);
        }

        public List<Company> GetAll()
        {
            return _companyDAL.GetList().ToList();
        }

        public Company GetById(int id)
        {
            return _companyDAL.Get(c => c.Id == id);
        }

        public List<Company> GetByMersisNo(int mersisNo)
        {
            return _companyDAL.GetList(c=>c.mersis_no==mersisNo).ToList();
        }

        public List<Company> GetByName(string companyName)
        {
            return _companyDAL.GetList(c=>c.company_name==companyName).ToList();
        }

        public List<Company> GetByVergiNo(int vergiNo)
        {
            return _companyDAL.GetList(c=>c.vergi_no==vergiNo).ToList();
        }

        public void Update(Company company)
        {
            _companyDAL.Update(company);
        }
    }
}
