using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class EfComplaintDal : EfEntityRepositoryBase<Complaint, KoEticaretContext>, IComplaintDal
    {

        public List<Complaint> GetAllComplaints()
        {
            using (var context = new KoEticaretContext())
            {
                return context.Complaints.Include("Customer").ToList();
            }
        }
    }
}
