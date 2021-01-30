using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnitTypeService
    {
        List<UnitType> GetAll();
        List<UnitType> GetById(int Id);
        UnitType GetUnitTypeName(string typeName);
        List<UnitType> GetUnitTypeAreaId_TypeName(int AreaId);
        void Add(UnitType unitType);
        void Delete(UnitType unitType);
        void Update(UnitType unitType);
    }
}
