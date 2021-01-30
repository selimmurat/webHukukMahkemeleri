using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDecisionTypeService
    {
        List<DecisionType> GetAll();
        DecisionType GetById(int id);
        DecisionType GetByName(string decisionName);
        void Add(DecisionType decisionType);
        void Delete(DecisionType decisionType);
        void Update(DecisionType decisionType);
    }
}
