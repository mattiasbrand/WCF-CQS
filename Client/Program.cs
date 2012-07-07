using System.Linq;
using Common;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new ServiceFacade();

            var query = new ListAvailablePoniesQuery();
            var result = facade.SendQuery(query);

            var command = new BarbequePonyCommand();
            command.PonyId = result.AvailablePonies.First().Id;
            facade.SendCommand(command);
        }
    }
}
