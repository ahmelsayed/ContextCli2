using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextCli2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ActionAttribute : Attribute
    {
        public Context Context { get; set; }

        public Context SubContext { get; set; }

        public string Name { get; set; }
    }
}
