using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface IComplaintService
    {
        List<Complaint> GetAll();
        Complaint GetbyId(int id);
        Complaint Add(Complaint complaint);
        Complaint Update(Complaint complaint);
        void Delete(Complaint complaint);
    }
}
