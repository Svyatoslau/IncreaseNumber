using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface IUpdateNumber
{
    public void UpdateNumber(RecordNumber recordNumber);
    public Task<RecordNumber> GetNumberById(int numberId);
    public Task Save();
}
