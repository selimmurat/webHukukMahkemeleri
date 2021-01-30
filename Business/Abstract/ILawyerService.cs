using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILawyerService
    {
        List<Lawyer> GetAll();
        Lawyer GetLawyerId(int lawyerId);
        Lawyer GetLawyerSicilNo(string lawyerSicilNo);
        Lawyer GetLawyerNameSurName(string name, string surName);
        void Add(Lawyer lawyer);
        void Delete(Lawyer lawyer);
        void Update(Lawyer lawyer);
    }
}
