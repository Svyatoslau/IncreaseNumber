using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberRepository : INumberGetSliceData, IUpdateNumber
{
    public Task<IEnumerable<Counter>> GetNumbers();
    public void UpdateNumber(Counter recordNumber);
    public Task Save();
    public Task<IEnumerable<Counter>> GetNumbers(int count);
    public Task<Counter> GetNumberById(int numberId);
    
}
