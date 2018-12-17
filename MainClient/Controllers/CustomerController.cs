using MainClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClient.Controllers
{
    class CustomerController
    {
        public void AddCustomer(String name, String email, String phone, String address)
        {

            if (!String.IsNullOrWhiteSpace(name) &&
               !String.IsNullOrWhiteSpace(email) &&
               !String.IsNullOrWhiteSpace(phone) &&
               !String.IsNullOrWhiteSpace(address))
            {
                Customer customer = new Customer();
                customer.Name = name;
                customer.Phone = phone;
                customer.Address = address;
                customer.Email = email;
                //ServiceReference1.Service1.AddCustomerAsync(customer);
            }
            else
            {
                
            }

        }

        public void UpdateCustomer(int id, String name, String email, String phone, String address)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Phone = phone;
            customer.Address = address;
            customer.Email = email;
            //ServiceReference1.Service1.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id, String name, String email, String phone, String address)
        {
            
            //ServiceReference1.Service1.DeleteCustomer(id);
        }

        public void GetAll()
        {
            List<Customer> list = new List<Customer>();
            //list = ServiceReference1.Service1.GetAllCustomers();
            //return list
        }
    }
}
