using System;

namespace Common.DataContracts.Commands
{
    public class BarbequePonyCommand : Command
    {
        public Guid PonyId { get; set; }
    }
}