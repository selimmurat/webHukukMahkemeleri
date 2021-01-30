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
        void Add(Adjective adjective);
        void Delete(Adjective adjective);
        void Update(Adjective adjective);
    }
}
