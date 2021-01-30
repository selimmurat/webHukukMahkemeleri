using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileStateTypeManager : IFileStateTypeService
    {
        IFileStateTypeDAL _fileStateTypeDAL;

        public FileStateTypeManager(IFileStateTypeDAL fileStateTypeDAL)
        {
            _fileStateTypeDAL = fileStateTypeDAL;
        }

        public void Add(FileStateType fileStateType)
        {
            _fileStateTypeDAL.Add(fileStateType);
        }

        public void Delete(FileStateType fileStateType)
        {
            _fileStateTypeDAL.Delete(fileStateType);
        }

        public List<FileStateType> GetAll()
        {
            return _fileStateTypeDAL.GetList().ToList();
        }

        public FileStateType GetFileStateName(string stateName)
        {
            return _fileStateTypeDAL.Get(f => f.file_state == stateName);
        }

        public FileStateType GetFileStateTypeId(int id)
        {
            return _fileStateTypeDAL.Get(f => f.Id == id);
        }

        public void Update(FileStateType fileStateType)
        {
            _fileStateTypeDAL.Update(fileStateType);
        }
    }
}
