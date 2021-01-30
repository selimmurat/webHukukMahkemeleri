using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UnitAreaManager : IUnitAreaService
    {
        IUnitAreaDAL _unitAreaDAL;

        public UnitAreaManager(IUnitAreaDAL unitAreaDAL)
        {
            this._unitAreaDAL = unitAreaDAL;
        }

        public void Add(UnitArea unitArea)
        {
            if (_unitAreaDAL.Get(u => u.unit_area_name == unitArea.unit_area_name) == null)
            {
                _unitAreaDAL.Add(unitArea);
            }
            else
            {
                throw new Exception("Eklemek istediğiniz Birim Alanı zaten Eklidir. Bilgileri kontrol ediniz. Sistem Yöneticisine başvurabilirsiniz.");
            }
        }

        public void Delete(UnitArea unitArea)
        {
            _unitAreaDAL.Delete(unitArea);
        }

        public List<UnitArea> GetAll()
        {
            return _unitAreaDAL.GetList().ToList();
        }

        public List<UnitArea> GetByAreaName(string areaName)
        {
            return _unitAreaDAL.GetList(u => u.unit_area_name == areaName).ToList();
        }

        public List<UnitArea> GetByAreaId(int Id)
        {
            return _unitAreaDAL.GetList(u => u.Id == Id).ToList();
        }

        public void Update(UnitArea unitArea)
        {
            _unitAreaDAL.Update(unitArea);
        }
    }
}
