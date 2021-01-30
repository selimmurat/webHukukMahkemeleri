using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDAL _cityDAL;

        public CityManager(ICityDAL cityDAL)
        {
            _cityDAL = cityDAL;
        }

        public void Add(City city)
        {
            _cityDAL.Add(city);
        }

        public void Delete(City city)
        {
            _cityDAL.Delete(city);
        }

        public List<City> GetAll()
        {
            return _cityDAL.GetList().ToList();
        }

        public City GetByCityId(int cityId)
        {
            return _cityDAL.Get(c => c.Id == cityId);
        }

        public City GetByCityName(string cityName)
        {
            return _cityDAL.Get(c => c.city_name == cityName);
        }

        public void Update(City city)
        {
            _cityDAL.Update(city);
        }
    }
}
