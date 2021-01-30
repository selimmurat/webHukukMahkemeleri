using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CaseTypeManager : ICaseTypeService
    {
        ICaseTypeDAL _caseTypeDAL;

        public CaseTypeManager(ICaseTypeDAL caseTypeDAL)
        {
            _caseTypeDAL = caseTypeDAL;
        }

        public void Add(CaseType caseType)
        {
            _caseTypeDAL.Add(caseType);
        }

        public void Delete(CaseType caseType)
        {
            _caseTypeDAL.Delete(caseType);
        }

        public List<CaseType> GetAll()
        {
            return _caseTypeDAL.GetList().ToList();
        }

        public List<CaseType> GetByCaseName(string caseName)
        {
            return _caseTypeDAL.GetList(c => c.case_name == caseName).ToList();
        }

        public CaseType GetById(int id)
        {
            return _caseTypeDAL.Get(c => c.Id == id);
        }

        public List<CaseType> GetByUnitTypeId_caseName(int unitTypeId)
        {
            return _caseTypeDAL.GetList(c => c.unit_type_Id == unitTypeId).ToList();
        }

        public void Update(CaseType caseType)
        {
            _caseTypeDAL.Update(caseType);
        }
    }
}
