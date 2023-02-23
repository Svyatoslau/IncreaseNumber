using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberGetSliceData
{
    public Task<IEnumerable<Counter>> GetNumbersAsync(int count);
}
