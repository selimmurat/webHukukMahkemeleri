using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICaseTypeService
    {
        List<CaseType> GetAll();
        CaseType GetById(int id);
        List<CaseType> GetByCaseName(string caseName);
        List<CaseType> GetByUnitTypeId_caseName(int unitTypeId);
        void Add(CaseType caseType);
        void Delete(CaseType caseType);
        void Update(CaseType caseType);
    }
}
