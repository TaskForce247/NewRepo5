using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService1.Cor.Models;
using WcfService1.Cor.Dto;

namespace WcfService1.Cor
{
    [ServiceContract]
    public interface ICustomerRepository
    {
        [OperationContract]
        Task<IEnumerable<WcfService1.Cor.Models.Customer>> GetAllCustomers();
        [OperationContract]
        Task<WcfService1.Cor.Models.Customer> GetCustomerById(int Id);
        [OperationContract]
        Task<IEnumerable<WcfService1.Cor.Models.Customer>> GetCustomersByName(string name);
        [OperationContract]
        void UpdateCustomer(WcfService1.Cor.Models.Customer customer);
        [OperationContract]
        Task AddCustomerAsync(WcfService1.Cor.Models.Customer customer);
        [OperationContract]
        void DeleteCustomer(int id);
    }
}
