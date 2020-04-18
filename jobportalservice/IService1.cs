using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace jobportalservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertData(CompanyDetails c);

        [OperationContract]
        DataSet GetCompanyData();

        [OperationContract]
        string ApplyForCompany(JobApplication a);

        [OperationContract]
        string AddUser(User u);

<<<<<<< HEAD

        [OperationContract]
        DataSet getUser(string username);

=======
>>>>>>> 75131fa61f20113d733be844fbb8e9ea071441f3
        [OperationContract]
        DataSet SelectUserbyCompany(string CompanyName);

        [OperationContract]
        string UpdateUser(User user);
        [OperationContract]
        DataSet SelectUserbyPostCompany(string CompanyName, string jobid);
        //[OperationContract]
        //DataSet SelectCompany(string company);
       
        [OperationContract]
        string Login(User u);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "jobportalservice.ContractType".
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
}
