using System;
using System.Collections.Generic;

namespace Incubator.UI.Model
{
    public class Step
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public IEnumerable<Step> Steps { get; set; }
        public int Repeats { get; set; }
    }
}
