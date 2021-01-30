using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileRegisterCompanyService
    {
        List<FileRegisterCompany> GetAll();
        List<FileRegisterCompany> GetById(int Id);
        List<FileRegisterCompany> GetByFileId(int fileId);
        List<FileRegisterCompany> GetByCompnayId(int companyId);
        void Add(FileRegisterCompany fileRegisterCompany);
        void Delete(FileRegisterCompany fileRegisterCompany);
        void Update(FileRegisterCompany fileRegisterCompany);

        // sonrasında iş kodları tasarlanıp ekleme yapılacak
    }
}
