using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnitService
    {
        List<Unit> GetAll();
        List<Unit> GetById(int id);
        List<Unit> GetByCode(int unitCode);
        List<Unit> GetByUnitName(string unitName);
        List<Unit> GetByTypeId_Units(int unitTypeId);
        void Add(Unit unit);
        void Delete(Unit unit);
        void Update(Unit unit);
    }
}
