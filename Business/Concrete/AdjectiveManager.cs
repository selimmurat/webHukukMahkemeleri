using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class AdjectiveManager : IAdjectiveService
    {
        IAdjectiveDAL _adjectiveDAL;

        public AdjectiveManager(IAdjectiveDAL adjectiveDAL)
        {
            _adjectiveDAL = adjectiveDAL;
        }

        public void Add(Adjective adjective)
        {
            _adjectiveDAL.Add(adjective);
        }

        public void Delete(Adjective adjective)
        {
            _adjectiveDAL.Delete(adjective);
        }

        public List<Adjective> GetAll()
        {
            return _adjectiveDAL.GetList().ToList();
        }

        public Adjective GetById(int id)
        {
            return _adjectiveDAL.Get(a => a.Id == id);
        }

        public Adjective GetByName(string name)
        {
            return _adjectiveDAL.Get(a => a.adjective_name == name);
        }

        public void Update(Adjective adjective)
        {
            _adjectiveDAL.Update(adjective);
        }
    }
}
