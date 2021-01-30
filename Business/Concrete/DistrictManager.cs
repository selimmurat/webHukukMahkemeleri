using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDAL _districtDAL;

        public DistrictManager(IDistrictDAL districtDAL)
        {
            _districtDAL = districtDAL;
        }

        public void Add(District district)
        {
            _districtDAL.Add(district);
        }

        public void Delete(District district)
        {
            _districtDAL.Delete(district);
        }

        public List<District> GetAll()
        {
            return _districtDAL.GetList().ToList();
        }

        public List<District> GetByCityId(int cityId)
        {
            return _districtDAL.GetList(d => d.city_id == cityId).ToList();
        }

        public District GetById(int districtId)
        {
            return _districtDAL.Get(d => d.Id == districtId);
        }

        public District GetByName(string districtName)
        {
            return _districtDAL.Get(d => d.district_name == districtName);
        }

        public void Update(District district)
        {
            _districtDAL.Update(district);
        }
    }
}
