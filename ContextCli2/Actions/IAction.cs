using System.Collections.Generic;
using System.Threading.Tasks;
using Fclp;

namespace ContextCli2.Actions
{
    internal interface IAction
    {
        ICommandLineParserResult ParseArgs(IEnumerable<string> args);
        Task RunAsync();
    }
}