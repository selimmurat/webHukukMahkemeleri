using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileCaseTypeService
    {
        List<FileCaseType> GetAll();
        List<FileCaseType> GetByFileId(int fileId);
        void Add(FileCaseType fileCaseType);
        void Delete(FileCaseType fileCaseType);
        void Update(FileCaseType fileCaseType);

        // talebe göre iş kodları yazılacak
    }
}
