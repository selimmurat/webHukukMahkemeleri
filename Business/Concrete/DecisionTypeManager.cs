using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class DecisionTypeManager : IDecisionTypeService
    {
        IDecisionTypeDAL _decisionTypeDAL;

        public DecisionTypeManager(IDecisionTypeDAL decisionTypeDAL)
        {
            _decisionTypeDAL = decisionTypeDAL;
        }

        public void Add(DecisionType decisionType)
        {
            _decisionTypeDAL.Add(decisionType);
        }

        public void Delete(DecisionType decisionType)
        {
            _decisionTypeDAL.Delete(decisionType);
        }

        public List<DecisionType> GetAll()
        {
            return _decisionTypeDAL.GetList().ToList();
        }

        public DecisionType GetById(int id)
        {
            return _decisionTypeDAL.Get(d => d.Id == id);
        }

        public DecisionType GetByName(string decisionName)
        {
            return _decisionTypeDAL.Get(d => d.decision_name == decisionName);
        }

        public void Update(DecisionType decisionType)
        {
            _decisionTypeDAL.Update(decisionType);
        }
    }
}
