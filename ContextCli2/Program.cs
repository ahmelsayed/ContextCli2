using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fclp;

namespace ContextCli2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new FluentCommandLineParser();
            p.Setup<int>('r', "name")
                .Callback(r => Console.WriteLine(r))
                .Required();
            p.Parse(args);
        }

        private static void ParseArgs(Stack<string> stack)
        {

        }
    }
}
