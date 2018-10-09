using System;
using System.Collections.Generic;
using System.Linq;

namespace Incubator.UI.Model
{
    public class Batch
    {
        public string Name { get; set; }
        public Program Program { get; set; }
        public IList<Event> Events { get; set; }
        public BatchState State { get; set; }

        public override string ToString()
        {
            return $"Batch: {Name} of {Program.Name}";
        }
    }

    public enum BatchState
    {
        New = 0x000,
        Ready = 0x001,
        Running = 0x010,
        Finished = 0x011,
        Error = 0x111,
    }
}
