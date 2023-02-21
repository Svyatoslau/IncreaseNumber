using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.DAL.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace IncreaseNumberAPI.DAL;

public class NumberRepository : INumberRepository
{
    private readonly NumberIncreaseContext _context;

    public NumberRepository(NumberIncreaseContext context) =>
        _context = context;

    public async Task<RecordNumber> GetNumberById(int numberId) =>
        await _context.RecordNumbers.FirstOrDefaultAsync(num => num.Id == numberId);
   

    public async Task<IEnumerable<RecordNumber>> GetNumbers() =>
        await _context.RecordNumbers.ToListAsync();

    public async Task<IEnumerable<RecordNumber>> GetNumbers(int count) =>
        await _context.RecordNumbers.Take(count).ToListAsync();

    public async Task Save() =>
        await _context.SaveChangesAsync();

    public void UpdateNumber(RecordNumber recordNumber)
    {
        _context.Entry(recordNumber).State= EntityState.Modified;
    }

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
