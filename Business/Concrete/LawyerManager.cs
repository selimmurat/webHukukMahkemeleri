using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class LawyerManager : ILawyerService
    {
        ILawyerDAL _lawyerDAL;

        public LawyerManager(ILawyerDAL lawyerDAL)
        {
            this._lawyerDAL = lawyerDAL;
        }

        public void Add(Lawyer lawyer)
        {
            _lawyerDAL.Add(lawyer);
        }

        public void Delete(Lawyer lawyer)
        {
            _lawyerDAL.Delete(lawyer);
        }

        public List<Lawyer> GetAll()
        {
            return _lawyerDAL.GetList().ToList();
        }

        public Lawyer GetLawyerId(int lawyerId)
        {
            return _lawyerDAL.Get(l => l.Id == lawyerId);
        }

        public Lawyer GetLawyerNameSurName(string name, string surName)
        {
            return _lawyerDAL.Get(l => l.name == name && l.surname == surName);
        }

        public Lawyer GetLawyerSicilNo(string lawyerSicilNo)
        {
            return _lawyerDAL.Get(l => l.sicil_no == lawyerSicilNo);
        }

        public void Update(Lawyer lawyer)
        {
            _lawyerDAL.Update(lawyer);
        }
    }
}
