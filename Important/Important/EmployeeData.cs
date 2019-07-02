using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Important
{
    [DataContract]
    public class EmployeeData
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Number { get; set; }

  
    }
}