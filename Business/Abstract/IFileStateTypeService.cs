using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileStateTypeService
    {
        List<FileStateType> GetAll();
        FileStateType GetFileStateTypeId(int id);
        FileStateType GetFileStateName(string stateName);
        void Add(FileStateType fileStateType);
        void Delete(FileStateType fileStateType);
        void Update(FileStateType fileStateType);
    }
}
