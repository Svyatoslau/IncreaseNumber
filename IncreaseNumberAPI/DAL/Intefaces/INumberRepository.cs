using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberRepository : INumberGetSliceData, IUpdateNumber
{
    public Task<IEnumerable<Counter>> GetNumbersAsync();
    public void UpdateNumber(Counter recordNumber);
    public Task SaveAsync();
    public Task<IEnumerable<Counter>> GetNumbersAsync(int count);
    public Task<Counter> GetNumberByIdAsync(int numberId);
    
}
