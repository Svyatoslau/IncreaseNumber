using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberRepository : INumberGetSliceData, IUpdateNumber
{
    public Task<IEnumerable<RecordNumber>> GetNumbers();
    public void UpdateNumber(RecordNumber recordNumber);
    public Task Save();
    public Task<IEnumerable<RecordNumber>> GetNumbers(int count);
    public Task<RecordNumber> GetNumberById(int numberId);
    
}
