using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.Aspects.ValidationAspects;
using KoProjectMvcBusiness.Abstract;
using KoProjectMvcBusiness.ValidationRules.FluentValidation;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcBusiness.Concrete.Managers
{
    public class ComplaintManager:IComplaintService
    {
        private IComplaintDal _complaintDal;

        public ComplaintManager(IComplaintDal complaintDal)
        {
            _complaintDal = complaintDal;
        }

        public List<Complaint> GetAll()
        {
            return _complaintDal.GetAllComplaints();
        }

        public Complaint GetbyId(int id)
        {
            return _complaintDal.Get(x=>x.ComplaintID==id);
        }
        [FluentValidationAspect(typeof(ComplaintValidatior))]
        public Complaint Add(Complaint complaint)
        {
            return _complaintDal.Add(complaint);
        }
        [FluentValidationAspect(typeof(ComplaintValidatior))]
        public Complaint Update(Complaint complaint)
        {
            return _complaintDal.Update(complaint);
        }

        public void Delete(Complaint complaint)
        {
            _complaintDal.Delete(complaint);
        }
    }
}
