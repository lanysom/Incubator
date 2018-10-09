using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace UI
{
    public static class Bootstrapper
    {
        public static readonly IContainer Container = new Container();

        public static void Initialize()
        {
            Container.Configure(c =>
            {

            });
        }
    }
}
