using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Important
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Employee.svc or Employee.svc.cs at the Solution Explorer and start debugging.
    public class Employee : IEmployee
    {

        public List<EmployeeData> GetEmployeeDatas()
        {
            List<EmployeeData> obj = new List<EmployeeData>();
            EmployeeData e = new EmployeeData();
            e.id =1;
            e.Name ="shiva";
            e.Address ="Bengaluru";
            e.Number =9;
                obj.Add(e);

            return obj;
        }
       

       

        public EmployeeData GetbyidEmployeeDatas(int id)
        {
            EmployeeData obj2 = new EmployeeData();
            if (id == 1)
            {
                obj2.id = 1;
                obj2.Name = "shiva";
                obj2.Address = "Bengaluru";
                obj2.Number = 9;

            }

            obj2 = new EmployeeData();
            if (id == 2)
            {
                obj2.id = 1;
                obj2.Name = "shiva";
                obj2.Address = "Bengaluru";
                obj2.Number = 9;

            }



            return obj2;
        }

    }
}

