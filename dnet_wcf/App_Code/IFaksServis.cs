using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IFaksServis
{

	[OperationContract] 
	void NoviStudent(string ime, int oib, int god_stud);

	[OperationContract]
	List<Student> ListaStudenata();

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Student	
{
    [DataMember]
    public int OIB
    {
        get; set;
    }

    [DataMember]
    public string Ime
    {
        get; set;
    }

    [DataMember]
    public int GodinaStudiranja
    {
        get; set;
    }
}
