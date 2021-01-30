using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetByRolId(int rolId);
        Role GetByRolName(string roleName);
        void Add(Role role);
        void Delete(Role role);
        void Update(Role role);
    }
}
