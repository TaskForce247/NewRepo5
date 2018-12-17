using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
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
        

        

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
            
        }
        
        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        [DataMember]
        public String Name
        {
            get { return Name; }
            set { Name = value; }
        }

        [DataMember]
        public String Email
        {
            get { return Email; }
            set { Email = value; }
        }
        [DataMember]
        public String Phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        [DataMember]
        public String Address
        {
            get { return Address; }
            set { Address = value; }
        }
        [Timestamp]
        public byte[] Version { get; set; }
    }
}
