
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService1;
using WcfService1.Cor.Models;

namespace WcfService1.Cor
{
    [ServiceContract]
    public interface IMCategoryRepository
    {
        [OperationContract]
        Task<IEnumerable<MCategory>> GetCategories();
    }
}
