using Host.Handlers.CommandHandlers;
using Host.Handlers.QueryHandlers;
using StructureMap;

namespace Host
{
    public class IoC
    {
        public static IContainer Container = Execute();
        static IContainer Execute()
        {
            return new Container(x =>
                                     {
                                         x.Scan(asm =>
                                         {
                                             asm.AssemblyContainingType<IHandleQuery>();
                                             asm.IncludeNamespaceContainingType<IHandleQuery>();
                                             asm.ConnectImplementationsToTypesClosing(typeof(QueryHandlerBase<,>));
                                         });
                                         x.Scan(asm =>
                                         {
                                             asm.AssemblyContainingType<IHandleCommand>();
                                             asm.IncludeNamespaceContainingType<IHandleCommand>();
                                             asm.ConnectImplementationsToTypesClosing(typeof(CommandHandlerBase<>));
                                         });
                                     });
        }
    }
}
