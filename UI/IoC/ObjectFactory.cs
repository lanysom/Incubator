using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.IoC
{
    public static class ObjectFactory
    {
        public static IContainer Container { get; }

        public static void Initialize(Action action)
        {

        }
    }
}
