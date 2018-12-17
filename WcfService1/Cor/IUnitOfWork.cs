using System.Threading.Tasks;

namespace WcfService1.Cor
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
