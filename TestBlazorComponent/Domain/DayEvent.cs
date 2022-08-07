using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorComponent.Domain
{
    public class DayEvent
    {
        public string? DateValue { get; set; }

        public string? DayName { get; set; }

        public bool Now { get; set; }

        public int ThisMonth { get; set; }

        public List<Event>? DayEvents { get; set; }
    }
}
