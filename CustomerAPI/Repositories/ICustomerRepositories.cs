using CustomerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Repositories
{
    public interface ICustomerRepositories
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(int id, Customer customer);
        int DeleteCustomer(int id);
    }
}
