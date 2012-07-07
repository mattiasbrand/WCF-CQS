using System;
using System.Runtime.Serialization;

namespace Common.DataContracts.Dtos
{
    [DataContract]
    public class PonyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
