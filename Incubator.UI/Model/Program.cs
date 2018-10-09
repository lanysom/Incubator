using System;
using System.Collections.Generic;

namespace Incubator.UI.Model
{
    public class Program
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Step> Steps { get; set; }
    }
}
