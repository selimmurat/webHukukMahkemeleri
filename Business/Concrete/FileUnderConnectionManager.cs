using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileUnderConnectionManager : IFileUnderConnectionService
    {
        IFileUnderConnectionDAL _fileUnderConnectionDAL;

        public FileUnderConnectionManager(IFileUnderConnectionDAL fileUnderConnectionDAL)
        {
            _fileUnderConnectionDAL = fileUnderConnectionDAL;
        }

        public void Add(FileUnderConnection fileUnderConnection)
        {
            _fileUnderConnectionDAL.Add(fileUnderConnection);
        }

        public void Delete(FileUnderConnection fileUnderConnection)
        {
            _fileUnderConnectionDAL.Delete(fileUnderConnection);
        }

        public List<FileUnderConnection> GetAll()
        {
            return _fileUnderConnectionDAL.GetList().ToList();
        }

        public void Update(FileUnderConnection fileUnderConnection)
        {
            _fileUnderConnectionDAL.Update(fileUnderConnection);
        }
    }
}
