using WcfService1.Cor;
using System.Threading.Tasks;


namespace WcfService1.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WaterLogicDbContext _context;

        public UnitOfWork(WaterLogicDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync() =>
            await _context.SaveChangesAsync();
    }
}
