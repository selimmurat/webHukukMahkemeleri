using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileSafahatStateService
    {
        List<FileSafahatState> GetAll();
        void Add(FileSafahatState fileSafahatState);
        void Delete(FileSafahatState fileSafahatState);
        void Update(FileSafahatState fileSafahatState);

        // iş katmanı iş kodları yazılacak isteğe göre ekleme olacak
    }
}
