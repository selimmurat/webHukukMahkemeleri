using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        List<District> GetAll();
        List<District> GetByCityId(int cityId);
        District GetById(int districtId);
        District GetByName(string districtName);
        void Add(District district);
        void Delete(District district);
        void Update(District district);
    }
}
