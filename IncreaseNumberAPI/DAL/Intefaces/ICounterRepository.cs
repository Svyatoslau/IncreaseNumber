using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface ICounterRepository : ICounterGetSliceData, ICounterUpdate
{
    public Task<List<Counter>> GetCountersAsync();
    public void UpdateCounter(Counter recordNumber);
    public Task SaveAsync();
    public Task<List<Counter>> GetCountersAsync(int count);
    public Task<Counter> GetCounterByIdAsync(int numberId);
    
}
