using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnitEndProcessRowNumberService
    {
        List<UnitEndProcessRowNumber> GetAll();
        void Add(UnitEndProcessRowNumber unitEndProcessRowNumber);
        void Delete(UnitEndProcessRowNumber unitEndProcessRowNumber);
        void Update(UnitEndProcessRowNumber unitEndProcessRowNumber);
        // daha sonra değerlendirilecek // concrete oluşuturlmadı.
    }
}
