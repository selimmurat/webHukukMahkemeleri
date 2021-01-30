using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnitOpenFileManager : IUnitOpenFileService
    {
        IUnitOpenFileDAL _unitOpenFileDAL;

        public UnitOpenFileManager(IUnitOpenFileDAL unitOpenFileDAL)
        {
            _unitOpenFileDAL = unitOpenFileDAL;
        }

        public void Add(UnitOpenFile unitOpenFile)
        {
            _unitOpenFileDAL.Add(unitOpenFile);
        }

        public void Delete(UnitOpenFile unitOpenFile)
        {
            _unitOpenFileDAL.Delete(unitOpenFile);
        }

        public List<UnitOpenFile> GetAll()
        {
            return _unitOpenFileDAL.GetList().ToList();
        }

        public void Update(UnitOpenFile unitOpenFile)
        {
            _unitOpenFileDAL.Update(unitOpenFile);
        }
    }
}
