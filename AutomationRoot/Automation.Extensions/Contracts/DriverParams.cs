using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Automation.Extensions.Contracts
{
    [DataContract]
    public class DriverParams
    {
       /* public DriverParams(string source, string driver, string binaries)
        {
            Source = source;
            Driver = driver;
            Binaries = binaries;
        }*/

        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string Driver { get; set; }
        [DataMember]
        public string Binaries { get; set; }
    }
}
