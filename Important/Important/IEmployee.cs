using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Important
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployee" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {
        [OperationContract]
        List<EmployeeData> GetEmployeeDatas();

        [OperationContract]
        EmployeeData GetbyidEmployeeDatas(int id);
    }
}
