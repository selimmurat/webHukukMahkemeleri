using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();  // veritabanında çok fazla kayıt olması halinde sıkıntı çıkartabilir.
        Company GetById(int id);
        List<Company> GetByMersisNo(int mersisNo);
        List<Company> GetByVergiNo(int vergiNo);
        List<Company> GetByName(string companyName);
        void Add(Company company);
        void Delete(Company company);
        void Update(Company company);
    }
}
