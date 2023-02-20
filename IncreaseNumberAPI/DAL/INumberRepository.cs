using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL;

public interface INumberRepository : IDisposable
{
    public Task<IEnumerable<RecordNumber>> GetNumbers();
    public Task<RecordNumber> GetNumberById(int numberId);
    public void UpdateNumber(RecordNumber recordNumber);
    public Task Save();

}
