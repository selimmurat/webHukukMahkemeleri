using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnitManager : IUnitService
    {
        IUnitDAL _unitDAL;

        public UnitManager(IUnitDAL unitDAL)
        {
            _unitDAL = unitDAL;
        }

        public void Add(Unit unit)
        {
            _unitDAL.Add(unit);
        }

        public void Delete(Unit unit)
        {
            _unitDAL.Delete(unit);
        }

        public List<Unit> GetAll()
        {
            return _unitDAL.GetList().ToList();
        }

        public List<Unit> GetByCode(int unitCode)
        {
            return _unitDAL.GetList(u => u.unit_code == unitCode).ToList();
        }

        public List<Unit> GetById(int id)
        {
            return _unitDAL.GetList(u => u.Id == id).ToList();
        }

        public List<Unit> GetByTypeId_Units(int unitTypeId)
        {
            return _unitDAL.GetList(u => u.unit_type_id == unitTypeId).ToList();
        }

        public List<Unit> GetByUnitName(string unitName)
        {
            return _unitDAL.GetList(u => u.unit_name == unitName).ToList();
        }

        public void Update(Unit unit)
        {
            _unitDAL.Delete(unit);
        }
    }
}
