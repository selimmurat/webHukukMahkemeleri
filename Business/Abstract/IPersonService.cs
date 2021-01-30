using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetByPersonId(int personId);
        Person GetByPersonTCNO(string personTCNo);
        Person GetByPersonNameSurname(string personName,string personSurName);
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);


    }
}
