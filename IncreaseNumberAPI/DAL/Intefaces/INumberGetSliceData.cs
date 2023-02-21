using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberGetSliceData
{
    public Task<IEnumerable<RecordNumber>> GetNumbers(int count);
}
