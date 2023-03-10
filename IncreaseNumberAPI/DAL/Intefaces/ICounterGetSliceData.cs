using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface ICounterGetSliceData
{
    public Task<List<Counter>> GetCountersAsync(int count);
}
