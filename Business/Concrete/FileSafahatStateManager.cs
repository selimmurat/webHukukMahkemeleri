using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class FileSafahatStateManager : IFileSafahatStateService
    {
        IFileSafahatStateDAL _fileSafahatStateDAL;

        public FileSafahatStateManager(IFileSafahatStateDAL fileSafahatStateDAL)
        {
            _fileSafahatStateDAL = fileSafahatStateDAL;
        }

        public void Add(FileSafahatState fileSafahatState)
        {
            _fileSafahatStateDAL.Add(fileSafahatState);
        }

        public void Delete(FileSafahatState fileSafahatState)
        {
            _fileSafahatStateDAL.Delete(fileSafahatState);
        }

        public List<FileSafahatState> GetAll()
        {
            return _fileSafahatStateDAL.GetList().ToList();
        }

        public void Update(FileSafahatState fileSafahatState)
        {
            _fileSafahatStateDAL.Update(fileSafahatState);
        }
    }
}
