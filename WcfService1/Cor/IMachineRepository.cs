using WcfService1.Cor.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService1.Cor.Models;

namespace WcfService1.Cor
{
    [ServiceContract]
    public interface IMachineRepository 
    {
        [OperationContract]
        Task<List<Machine>> GetMachines(string category = null);
        [OperationContract]
        Task<Machine> GetMachineById(int machineId);
        [OperationContract]
        Task<List<MachineNameIdDto>> GetAllMachinesNameId();
        [OperationContract]
        void UpdateMachine(Machine machine);
        [OperationContract]
        Task AddMachineAsync(Machine machine);
        [OperationContract]
        void Delete(int id);
        [OperationContract]
        Task<List<MCategory>> GetCategoriesAsync();
    }
}
