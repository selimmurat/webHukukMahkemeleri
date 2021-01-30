using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDAL _personDAL;

        public PersonManager(IPersonDAL personDAL)
        {
            _personDAL = personDAL;
        }

        public void Add(Person person)
        {
            _personDAL.Add(person);
        }

        public void Delete(Person person)
        {
            _personDAL.Delete(person);
        }

        public List<Person> GetAll()
        {
            return _personDAL.GetList().ToList();
        }

        public Person GetByPersonId(int personId)
        {
            return _personDAL.Get(p => p.Id == personId);
        }

        public Person GetByPersonNameSurname(string personName, string personSurName)
        {
            return _personDAL.Get(p => p.name == personName && p.surname == personSurName);
        }

        public Person GetByPersonTCNO(string personTCNo)
        {
            return _personDAL.Get(p => p.TC_NO == personTCNo);
        }

        public void Update(Person person)
        {
            _personDAL.Update(person);
        }
    }
}
