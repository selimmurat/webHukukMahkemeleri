using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILawWayService
    {
        List<LawWay> GetAll();
        LawWay GetByLawWayId(int id);
        LawWay GetByLawWayName(string lawWayName);
        void Add(LawWay lawWay);
        void Delete(LawWay lawWay);
        void Update(LawWay lawWay);
    }
}
