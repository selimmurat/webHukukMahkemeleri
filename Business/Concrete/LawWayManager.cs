using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class LawWayManager : ILawWayService
    {
        ILawWayDAL _lawWayDAL;

        public LawWayManager(ILawWayDAL lawWayDAL)
        {
            _lawWayDAL = lawWayDAL;
        }

        public void Add(LawWay lawWay)
        {
            _lawWayDAL.Add(lawWay);
        }

        public void Delete(LawWay lawWay)
        {
            _lawWayDAL.Delete(lawWay);
        }

        public List<LawWay> GetAll()
        {
            return _lawWayDAL.GetList().ToList();
        }

        public LawWay GetByLawWayId(int id)
        {
            return _lawWayDAL.Get(l => l.Id == id);
        }

        public LawWay GetByLawWayName(string lawWayName)
        {
            return _lawWayDAL.Get(l => l.law_way_name == lawWayName);
        }

        public void Update(LawWay lawWay)
        {
            _lawWayDAL.Update(lawWay);
        }
    }
}
