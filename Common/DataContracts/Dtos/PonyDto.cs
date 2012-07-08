using System;
using System.Runtime.Serialization;

namespace Common.DataContracts.Dtos
{
    [DataContract]
    public class PonyDto
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
