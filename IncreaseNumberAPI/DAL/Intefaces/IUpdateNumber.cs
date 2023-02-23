using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface IUpdateNumber
{
    public void UpdateNumber(Counter recordNumber);
    public Task<Counter> GetNumberById(int numberId);
    public Task Save();
}
