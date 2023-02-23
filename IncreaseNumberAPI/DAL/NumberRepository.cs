using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.DAL.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace IncreaseNumberAPI.DAL;

public class NumberRepository : INumberRepository
{
    private readonly TestDbContext _context;

    public NumberRepository(TestDbContext context) =>
        _context = context;

    public async Task<Counter> GetNumberByIdAsync(int numberId) =>
        await _context.Counters.FirstOrDefaultAsync(num => num.Id == numberId);
   

    public async Task<IEnumerable<Counter>> GetNumbersAsync() =>
        await _context.Counters.ToListAsync();

    public async Task<IEnumerable<Counter>> GetNumbersAsync(int count) =>
        await _context.Counters.Take(count).ToListAsync();

    public async Task SaveAsync() =>
        await _context.SaveChangesAsync();

    public void UpdateNumber(Counter recordNumber) =>
        _context.Entry(recordNumber).State= EntityState.Modified;
}
