using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileTypeManager : IFileTypeService
    {
        IFileTypeDAL _fileTypeDAL;

        public FileTypeManager(IFileTypeDAL fileTypeDAL)
        {
            _fileTypeDAL = fileTypeDAL;
        }

        public void Add(FileType fileType)
        {
            _fileTypeDAL.Add(fileType);
        }

        public void Delete(FileType fileType)
        {
            _fileTypeDAL.Delete(fileType);
        }

        public List<FileType> GetAll()
        {
            return _fileTypeDAL.GetList().ToList();
        }

        public FileType GetFileTypeId(int id)
        {
            return _fileTypeDAL.Get(f => f.Id == id);
        }

        public FileType GetFileTypeName(string typeName)
        {
            return _fileTypeDAL.Get(f => f.file_type_name == typeName);
        }

        public void Update(FileType fileType)
        {
            _fileTypeDAL.Update(fileType);
        }
    }
}
