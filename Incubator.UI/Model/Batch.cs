using System;
using System.Collections.Generic;
using System.Linq;

namespace Incubator.UI.Model
{
    public class Batch
    {
        public int Id { get; set; }
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
        New = 0,
        Ready = 1,
        Running = 2,
        Finished = 3,
        Error = 4,
    }
}
