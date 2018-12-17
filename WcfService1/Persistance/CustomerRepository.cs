using WcfService1.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcfService1.Cor;
using WcfService1.Cor.Models;

namespace WcfService1.Persistance
{
    public class CustomerRepository : ICustomerRepository
    {
        
        private readonly WaterLogicDbContext _context;

        public CustomerRepository(WaterLogicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WcfService1.Cor.Models.Customer>> GetAllCustomers()
        {
            var customers = _context.Customers.AsQueryable();
            return await customers.ToListAsync();
        }

        public async Task<WcfService1.Cor.Models.Customer> GetCustomerById(int Id)
        {
            return await _context.Customers.FirstAsync(e => e.Id == Id);

        }

        public async Task<IEnumerable<WcfService1.Cor.Models.Customer>> GetCustomersByName(string name)
        {
            var customers = _context.Customers.Where
                (e => e.Name == name);
            if (customers != null)
                return await customers.ToListAsync();
            else
                return null;
        }

        public void UpdateCustomer(WcfService1.Cor.Models.Customer customer)
        {
            _context.Update(customer);
        }
        public async Task AddCustomerAsync(WcfService1.Cor.Models.Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }
        public void DeleteCustomer(int id)
        {
            var cust = new WcfService1.Cor.Models.Customer { Id = id };
            _context.Entry(cust).State = EntityState.Deleted;
        }
    }
}