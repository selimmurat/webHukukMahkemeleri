using Business.Abstract;
using Core.Utilities.Result;
using Core.Utilities.Result.Concrete;
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

        public IResult Add(Adjective adjective)
        {
            _adjectiveDAL.Add(adjective);
            return new Result(true, "");
        }

        public IResult Delete(Adjective adjective)
        {
            _adjectiveDAL.Delete(adjective);
            return new SuccessResult("Başarılı bir şekilde silindi");
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

        public IResult Update(Adjective adjective)
        {
            _adjectiveDAL.Update(adjective);
            return new SuccessResult("Güncelleme işlemi başarılı");
        }
    }
}
