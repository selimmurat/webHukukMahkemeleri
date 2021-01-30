using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileRegisterCompanyManager : IFileRegisterCompanyService
    {
        IFileRegisterCompanyDAL _fileRegisterCompanyDAL;

        public FileRegisterCompanyManager(IFileRegisterCompanyDAL fileRegisterCompanyDAL)
        {
            _fileRegisterCompanyDAL = fileRegisterCompanyDAL;
        }

        public void Add(FileRegisterCompany fileRegisterCompany)
        {
            _fileRegisterCompanyDAL.Add(fileRegisterCompany);
        }

        public void Delete(FileRegisterCompany fileRegisterCompany)
        {
            _fileRegisterCompanyDAL.Delete(fileRegisterCompany);
        }

        public List<FileRegisterCompany> GetAll()
        {
            return _fileRegisterCompanyDAL.GetList().ToList();
        }

        public List<FileRegisterCompany> GetByCompnayId(int companyId)
        {
            return _fileRegisterCompanyDAL.GetList(f => f.company_Id == companyId).ToList();
        }

        public List<FileRegisterCompany> GetByFileId(int fileId)
        {
            return _fileRegisterCompanyDAL.GetList(f => f.file_Id == fileId).ToList();
        }

        public List<FileRegisterCompany> GetById(int Id)
        {
            return _fileRegisterCompanyDAL.GetList(f => f.Id == Id).ToList();
        }

        public void Update(FileRegisterCompany fileRegisterCompany)
        {
            _fileRegisterCompanyDAL.Update(fileRegisterCompany);
        }
    }
}
