using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface ICounterUpdate
{
    public void UpdateCounter(Counter recordNumber);
    public Task<Counter> GetCounterByIdAsync(int numberId);
    public Task SaveAsync();
}
