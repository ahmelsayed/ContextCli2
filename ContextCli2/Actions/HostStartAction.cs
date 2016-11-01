using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fclp;

namespace ContextCli2.Actions
{
    [Action(Context = Context.Host, SubContext = Context.Account)]
    class HostActions : IAction
    {
        public ICommandLineParserResult ParseArgs(IEnumerable<string> args)
        {
            throw new NotImplementedException();
        }

        public Task RunAsync()
        {
            throw new NotImplementedException();
        }
    }
}
