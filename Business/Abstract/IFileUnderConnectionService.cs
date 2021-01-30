using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFileUnderConnectionService
    {
        List<FileUnderConnection> GetAll();
        void Add(FileUnderConnection fileUnderConnection);
        void Delete(FileUnderConnection fileUnderConnection);
        void Update(FileUnderConnection fileUnderConnection);

        // talebe göre iş katmanı kodları eklenecek
    }
}
