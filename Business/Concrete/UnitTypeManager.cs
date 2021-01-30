using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnitTypeManager : IUnitTypeService
    {
        IUnitTypeDAL _unitTypeDAL;

        public UnitTypeManager(IUnitTypeDAL unitTypeDAL)
        {
            _unitTypeDAL = unitTypeDAL;
        }

        public void Add(UnitType unitType)
        {
            _unitTypeDAL.Add(unitType);
        }

        public void Delete(UnitType unitType)
        {
            _unitTypeDAL.Delete(unitType);
        }

        public List<UnitType> GetAll()
        {
            return _unitTypeDAL.GetList().ToList();
        }

        public List<UnitType> GetById(int Id)
        {
            return _unitTypeDAL.GetList(u => u.Id == Id).ToList();
        }

        public List<UnitType> GetUnitTypeAreaId_TypeName(int AreaId)
        {
            return _unitTypeDAL.GetList(u => u.unit_area_id == AreaId).ToList();
        }

        public UnitType GetUnitTypeName(string typeName)
        {
            return _unitTypeDAL.Get(u => u.unit_type_name == typeName);
        }

        public void Update(UnitType unitType)
        {
            _unitTypeDAL.Delete(unitType);
        }
    }
}
