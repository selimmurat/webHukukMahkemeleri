using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnitEndProcessRowNumberManager : IUnitEndProcessRowNumberService
    {
        IUnitEndProcessRowNumberDAL _unitEndProcessRowNumberDAL;

        public UnitEndProcessRowNumberManager(IUnitEndProcessRowNumberDAL unitEndProcessRowNumberDAL)
        {
            _unitEndProcessRowNumberDAL = unitEndProcessRowNumberDAL;
        }

        public void Add(UnitEndProcessRowNumber unitEndProcessRowNumber)
        {
            _unitEndProcessRowNumberDAL.Add(unitEndProcessRowNumber);
        }

        public void Delete(UnitEndProcessRowNumber unitEndProcessRowNumber)
        {
            _unitEndProcessRowNumberDAL.Delete(unitEndProcessRowNumber);
        }

        public List<UnitEndProcessRowNumber> GetAll()
        {
            return _unitEndProcessRowNumberDAL.GetList().ToList();
        }

        public void Update(UnitEndProcessRowNumber unitEndProcessRowNumber)
        {
            _unitEndProcessRowNumberDAL.Update(unitEndProcessRowNumber);
        }
    }
}
