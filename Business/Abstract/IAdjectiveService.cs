using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdjectiveService
    {
        List<Adjective> GetAll();
        Adjective GetById(int id);
        Adjective GetByName(string name);
        IResult Add(Adjective adjective);
        IResult Delete(Adjective adjective);
        IResult Update(Adjective adjective);
    }
}
