using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestBlazorComponent.Domain;

namespace TestBlazorComponent.Abstractions
{
    public interface IRepository
    {
        Task<Event> GetByIdAsync(Guid id);

        Task AddAsync(Event ev);

        Task UpdateAsync(Event ev);

        Task DeleteAsync(Event ev);

        Task<List<Event>> GetWhereAsync(Expression<Func<Event, bool>> predicate);
    }
}
