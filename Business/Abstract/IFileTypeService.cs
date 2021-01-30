using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileTypeService
    {
        List<FileType> GetAll();
        FileType GetFileTypeId(int id);
        FileType GetFileTypeName(string typeName);
        void Add(FileType fileType);
        void Delete(FileType fileType);
        void Update(FileType fileType);
    }
}
