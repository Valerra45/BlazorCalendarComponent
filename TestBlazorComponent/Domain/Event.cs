using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorComponent.Domain
{
    public class Event
    {
        public Guid Id { get; set; }

        public string? Note { get; set; }

        public string? DayName { get; set; }

        public bool AllDay { get; set; }

        public DateTime EventDate { get; set; }
    }
}
