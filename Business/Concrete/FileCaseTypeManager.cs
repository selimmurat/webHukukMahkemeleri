using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileCaseTypeManager : IFileCaseTypeService
    {
        IFileCaseTypeDAL _fileCaseTypeDAL;

        public FileCaseTypeManager(IFileCaseTypeDAL fileCaseTypeDAL)
        {
            this._fileCaseTypeDAL = fileCaseTypeDAL;
        }

        public void Add(FileCaseType fileCaseType)
        {
            _fileCaseTypeDAL.Add(fileCaseType);
        }

        public void Delete(FileCaseType fileCaseType)
        {
            _fileCaseTypeDAL.Delete(fileCaseType);
        }

        public List<FileCaseType> GetAll()
        {
            return _fileCaseTypeDAL.GetList().ToList();
        }

        public List<FileCaseType> GetByFileId(int fileId)
        {
            return _fileCaseTypeDAL.GetList(f => f.file_Id == fileId).ToList();
        }

        public void Update(FileCaseType fileCaseType)
        {
            _fileCaseTypeDAL.Update(fileCaseType);
        }
    }
}
