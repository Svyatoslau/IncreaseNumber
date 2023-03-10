using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.DAL.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace IncreaseNumberAPI.DAL;

public class CounterRepository : ICounterRepository
{
    private readonly TestDbContext _context;

    public CounterRepository(TestDbContext context) =>
        _context = context;

    public async Task<Counter> GetCounterByIdAsync(int numberId) =>
        await _context.Counters.FirstOrDefaultAsync(num => num.Id == numberId);
   

    public async Task<List<Counter>> GetCountersAsync() =>
        await _context.Counters.ToListAsync();

    public async Task<List<Counter>> GetCountersAsync(int count) =>
        await _context.Counters.Take(count).ToListAsync();

    public async Task SaveAsync() =>
        await _context.SaveChangesAsync();

    public void UpdateCounter(Counter recordNumber) =>
        _context.Entry(recordNumber).State= EntityState.Modified;
}
