using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlazorComponent.Data.Components
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EventDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EventDbContext>>()))
            {
                context.Database.EnsureDeleted();

                if (context.Database.EnsureCreated())
                {
                    context.Events!.AddRange(FakeDataFactory.Events());

                    context.SaveChanges();
                }
            }
        }
    }
}
