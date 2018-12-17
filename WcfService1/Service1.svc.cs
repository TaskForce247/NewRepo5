using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfService1.Cor;
using WcfService1.Cor.Dto;
using WcfService1.Cor.Models;
using WcfService1.Persistance;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IMachineRepository
    {
        
        public Task AddMachineAsync(Machine machine)
        {
            return AddMachineAsync(machine);
        }

        public void Delete(int id)
        {
            Delete(id);
        }

        public Task<List<MachineNameIdDto>> GetAllMachinesNameId()
        {
            return GetAllMachinesNameId();
        }

        public Task<List<MCategory>> GetCategoriesAsync()
        {
            return GetCategoriesAsync();
        }

        public Task<Machine> GetMachineById(int machineId)
        {
            return GetMachineById(machineId);
        }

        public Task<List<Machine>> GetMachines(string category = null)
        {
            return GetMachines(category);

        }

        public void UpdateMachine(Machine machine)
        {
            UpdateMachine(machine);
        }
        

        
    }

    public class Service2 : IService1
    {
        CustomerRepository customerRepository = new CustomerRepository(WaterLogicDbContext.getContext());
        public async Task AddCustomerAsync(Cor.Models.Customer customer)
        {
            await customerRepository.AddCustomerAsync(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerRepository.DeleteCustomer(id);
        }

        public async Task<IEnumerable<Cor.Models.Customer>> GetAllCustomers()
        {
            return await customerRepository.GetAllCustomers();
        }

        public async Task<Cor.Models.Customer> GetCustomerById(int Id)
        {
            return await customerRepository.GetCustomerById(Id);
        }

        public async Task<IEnumerable<Cor.Models.Customer>> GetCustomersByName(string name)
        {
            return await customerRepository.GetCustomersByName(name);
        }

        public void UpdateCustomer(Cor.Models.Customer customer)
        {
            customerRepository.UpdateCustomer(customer);
        }
    }


}
