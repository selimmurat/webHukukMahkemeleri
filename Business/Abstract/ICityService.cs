using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetByCityId(int cityId);
        City GetByCityName(string cityName);
        void Add(City city);
        void Delete(City city);
        void Update(City city);
    }
}
