using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMC.Service.Repository
{
    interface ICustomerRepository
    {
        IEnumerable<CustomerEntity> GetAllCustomers();
        void AddCustomer(CustomerEntity customer);
        void DeleteCustomer(int id);
        void EditCustomer(CustomerEntity customer);
        int GetCustomersCount();
    }
}
