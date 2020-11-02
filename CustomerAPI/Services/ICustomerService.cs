using CustomerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Services
{
    public interface ICustomerService 
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int id);
        int AddCustomer(Customer customer);
        int UpdateCustomer(int id, Customer customer);
        int DeleteCustomer(int id);
    }
}
