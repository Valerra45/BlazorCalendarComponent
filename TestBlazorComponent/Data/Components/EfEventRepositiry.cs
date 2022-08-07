using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestBlazorComponent.Abstractions;
using TestBlazorComponent.Domain;

namespace TestBlazorComponent.Data.Components
{
    public class EfEventRepositiry : IRepository
    {
        private readonly EventDbContext _context;

        public EfEventRepositiry(EventDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Event ev)
        {
            await _context.Events!.AddAsync(ev);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Event ev)
        {
             _context.Events!.Remove(ev);

            await _context.SaveChangesAsync();
        }

        public async Task<Event> GetByIdAsync(Guid id)
        {
            var entity = await _context.Events!.FirstOrDefaultAsync(x => x.Id == id);

            return entity!;
        }

        public async Task<List<Event>> GetWhereAsync(Expression<Func<Event, bool>> predicate)
        {
            return await _context.Events!.Where(predicate).ToListAsync();
        }

        public async Task UpdateAsync(Event ev)
        {
            _context.Events!.Update(ev);

            await _context.SaveChangesAsync();
        }
    }
}
