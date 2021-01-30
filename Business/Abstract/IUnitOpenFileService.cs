using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnitOpenFileService
    {
        List<UnitOpenFile> GetAll();
        void Add(UnitOpenFile unitOpenFile);
        void Delete(UnitOpenFile unitOpenFile);
        void Update(UnitOpenFile unitOpenFile);
        // daha sonra bakılacak...  Concrete Manager oluşturulmadı.
    }
}
