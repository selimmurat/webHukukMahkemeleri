using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDAL _roleDAL;

        public RoleManager(IRoleDAL roleDAL)
        {
            _roleDAL = roleDAL;
        }

        public void Add(Role role)
        {
            _roleDAL.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDAL.Delete(role);
        }

        public List<Role> GetAll()
        {
            return _roleDAL.GetList().ToList();
        }

        public Role GetByRolId(int rolId)
        {
            return _roleDAL.Get(r => r.Id == rolId);
        }

        public Role GetByRolName(string roleName)
        {
            return _roleDAL.Get(r => r.role_name == roleName);
        }

        public void Update(Role role)
        {
            _roleDAL.Update(role);
        }
    }
}
