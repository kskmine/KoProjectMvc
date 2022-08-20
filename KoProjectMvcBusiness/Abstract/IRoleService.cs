using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetbyId(int id);
        Role Add(Role role);
        Role Update(Role role);
        void Delete(Role role);
        Role GetbyRoleName(string roleName);
    }
}
