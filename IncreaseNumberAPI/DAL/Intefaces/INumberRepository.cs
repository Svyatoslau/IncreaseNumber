using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface INumberRepository : IDisposable, INumberGetSliceData
{
    public Task<IEnumerable<RecordNumber>> GetNumbers();
    public Task<RecordNumber> GetNumberById(int numberId);
    public void UpdateNumber(RecordNumber recordNumber);
    public Task Save();

}
