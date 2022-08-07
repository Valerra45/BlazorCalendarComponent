using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorComponent.Models
{
    public class EventModel
    {
        public Guid Id { get; set; }

        public string? Note { get; set; }

        public string? DayName { get; set; }

        public DateTime Time { get; set; }

        public bool AllDay { get; set; }
    }
}
