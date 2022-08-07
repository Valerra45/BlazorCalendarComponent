using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBlazorComponent.Domain;

namespace TestBlazorComponent.Data.Components
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Event>? Events { get; set; }
    }
}
