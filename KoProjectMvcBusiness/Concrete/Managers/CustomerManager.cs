using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.Aspects.ValidationAspects;
using KoProjectMvcBusiness.Abstract;
using KoProjectMvcBusiness.ValidationRules.FluentValidation;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcBusiness.Concrete.Managers
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.Get(filter);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAllCustomer();
        }

        public Customer GetbyId(int id)
        {
            return _customerDal.Get(x => x.CustomerID == id);
        }

        public Customer GetByIdUser(int id)
        {
            return _customerDal.GetByIdUser(id);
        }
        [FluentValidationAspect(typeof(CustomerValidatior))]
        public Customer Add(Customer customer)
        {
            return _customerDal.Add(customer);
        }
        [FluentValidationAspect(typeof(CustomerValidatior))]
        public Customer Update(Customer customer)
        {
            return _customerDal.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
    }
}
