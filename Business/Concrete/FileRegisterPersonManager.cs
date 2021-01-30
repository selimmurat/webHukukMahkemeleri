using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileRegisterPersonManager : IFileRegisterPersonService
    {
        IFileRegisterPersonDAL _fileRegisterPersonDAL;

        public FileRegisterPersonManager(IFileRegisterPersonDAL fileRegisterPersonDAL)
        {
            _fileRegisterPersonDAL = fileRegisterPersonDAL;
        }

        public void Add(FileRegisterPerson fileRegisterPerson)
        {
            _fileRegisterPersonDAL.Add(fileRegisterPerson);
        }

        public void Delete(FileRegisterPerson fileRegisterPerson)
        {
            _fileRegisterPersonDAL.Delete(fileRegisterPerson);
        }

        public List<FileRegisterPerson> GetAll()
        {
            return _fileRegisterPersonDAL.GetList().ToList();
        }

        public List<FileRegisterPerson> GetByFileId(int fileId)
        {
            return _fileRegisterPersonDAL.GetList(p => p.file_Id == fileId).ToList();
        }

        public List<FileRegisterPerson> GetById(int Id)
        {
            return _fileRegisterPersonDAL.GetList(p => p.Id == Id).ToList();
        }

        public List<FileRegisterPerson> GetByPersonId(int personId)
        {
            return _fileRegisterPersonDAL.GetList(p => p.person_Id == personId).ToList();
        }

        public void Update(FileRegisterPerson fileRegisterPerson)
        {
            _fileRegisterPersonDAL.Update(fileRegisterPerson);
        }
    }
}
