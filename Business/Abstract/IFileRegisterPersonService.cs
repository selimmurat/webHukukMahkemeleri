using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileRegisterPersonService
    {
        List<FileRegisterPerson> GetAll();
        List<FileRegisterPerson> GetById(int Id);
        List<FileRegisterPerson> GetByFileId(int fileId);
        List<FileRegisterPerson> GetByPersonId(int personId);
        void Add(FileRegisterPerson fileRegisterPerson);
        void Delete(FileRegisterPerson fileRegisterPerson);
        void Update(FileRegisterPerson fileRegisterPerson);

        // iş katmanı sonra değerlendirme yapılacak
    }
}
