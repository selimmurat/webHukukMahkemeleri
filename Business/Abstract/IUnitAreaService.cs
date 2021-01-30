using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnitAreaService
    {
        List<UnitArea> GetAll();
        List<UnitArea> GetByAreaId(int Id);
        List<UnitArea> GetByAreaName(string areaName);
        void Add(UnitArea unitArea);
        void Delete(UnitArea unitArea);
        void Update(UnitArea unitArea);
    }
}
