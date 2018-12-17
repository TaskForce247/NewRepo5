

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcfService1.Cor;
using WcfService1.Cor.Models;

namespace WcfService1.Persistance
{
    public class MCategoryRepository : IMCategoryRepository
    {

        private readonly WaterLogicDbContext _context;

        public MCategoryRepository(WaterLogicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MCategory>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
