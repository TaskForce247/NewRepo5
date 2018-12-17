﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Machine", Namespace="http://schemas.datacontract.org/2004/07/WaterLoggic.Core.Models")]
    public partial class Machine : object
    {
        
        private MService.MCategory CategoryField;
        
        private int CategoryIdField;
        
        private int IdField;
        
        private string ImageUrlField;
        
        private string LongDescriptionField;
        
        private string NameField;
        
        private decimal PriceField;
        
        private string ShortDescriptionField;
        
        private byte[] VersionField;
        
        private bool availableField;
        
        private int stockField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MService.MCategory Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId
        {
            get
            {
                return this.CategoryIdField;
            }
            set
            {
                this.CategoryIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl
        {
            get
            {
                return this.ImageUrlField;
            }
            set
            {
                this.ImageUrlField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LongDescription
        {
            get
            {
                return this.LongDescriptionField;
            }
            set
            {
                this.LongDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortDescription
        {
            get
            {
                return this.ShortDescriptionField;
            }
            set
            {
                this.ShortDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Version
        {
            get
            {
                return this.VersionField;
            }
            set
            {
                this.VersionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MCategory", Namespace="http://schemas.datacontract.org/2004/07/WaterLoggic.Core.Models")]
    public partial class MCategory : object
    {
        
        private int IdField;
        
        private MService.Machine[] MachinesField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MService.Machine[] Machines
        {
            get
            {
                return this.MachinesField;
            }
            set
            {
                this.MachinesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MachineNameIdDto", Namespace="http://schemas.datacontract.org/2004/07/WaterLoggic.Core.Dto")]
    public partial class MachineNameIdDto : object
    {
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MService.IMachineRepository")]
    public interface IMachineRepository
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/GetMachines", ReplyAction="http://tempuri.org/IMachineRepository/GetMachinesResponse")]
        System.Threading.Tasks.Task<MService.Machine[]> GetMachinesAsync(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/GetMachineById", ReplyAction="http://tempuri.org/IMachineRepository/GetMachineByIdResponse")]
        System.Threading.Tasks.Task<MService.Machine> GetMachineByIdAsync(int machineId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/GetAllMachinesNameId", ReplyAction="http://tempuri.org/IMachineRepository/GetAllMachinesNameIdResponse")]
        System.Threading.Tasks.Task<MService.MachineNameIdDto[]> GetAllMachinesNameIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/UpdateMachine", ReplyAction="http://tempuri.org/IMachineRepository/UpdateMachineResponse")]
        System.Threading.Tasks.Task UpdateMachineAsync(MService.Machine machine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/AddMachine", ReplyAction="http://tempuri.org/IMachineRepository/AddMachineResponse")]
        System.Threading.Tasks.Task AddMachineAsync(MService.Machine machine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/Delete", ReplyAction="http://tempuri.org/IMachineRepository/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachineRepository/GetCategories", ReplyAction="http://tempuri.org/IMachineRepository/GetCategoriesResponse")]
        System.Threading.Tasks.Task<MService.MCategory[]> GetCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IMachineRepositoryChannel : MService.IMachineRepository, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class MachineRepositoryClient : System.ServiceModel.ClientBase<MService.IMachineRepository>, MService.IMachineRepository
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MachineRepositoryClient() : 
                base(MachineRepositoryClient.GetDefaultBinding(), MachineRepositoryClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMachineRepository.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineRepositoryClient(EndpointConfiguration endpointConfiguration) : 
                base(MachineRepositoryClient.GetBindingForEndpoint(endpointConfiguration), MachineRepositoryClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineRepositoryClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MachineRepositoryClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineRepositoryClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MachineRepositoryClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineRepositoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<MService.Machine[]> GetMachinesAsync(string category)
        {
            return base.Channel.GetMachinesAsync(category);
        }
        
        public System.Threading.Tasks.Task<MService.Machine> GetMachineByIdAsync(int machineId)
        {
            return base.Channel.GetMachineByIdAsync(machineId);
        }
        
        public System.Threading.Tasks.Task<MService.MachineNameIdDto[]> GetAllMachinesNameIdAsync()
        {
            return base.Channel.GetAllMachinesNameIdAsync();
        }
        
        public System.Threading.Tasks.Task UpdateMachineAsync(MService.Machine machine)
        {
            return base.Channel.UpdateMachineAsync(machine);
        }
        
        public System.Threading.Tasks.Task AddMachineAsync(MService.Machine machine)
        {
            return base.Channel.AddMachineAsync(machine);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        public System.Threading.Tasks.Task<MService.MCategory[]> GetCategoriesAsync()
        {
            return base.Channel.GetCategoriesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMachineRepository))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMachineRepository))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52420/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MachineRepositoryClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMachineRepository);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MachineRepositoryClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMachineRepository);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMachineRepository,
        }
    }
}
