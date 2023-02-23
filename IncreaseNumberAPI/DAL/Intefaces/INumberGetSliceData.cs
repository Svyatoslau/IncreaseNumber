using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberGetSliceData
{
    public Task<IEnumerable<Counter>> GetNumbers(int count);
}
