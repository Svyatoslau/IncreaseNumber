using IncreaseNumberAPI.DAL.Entities;

namespace IncreaseNumberAPI.DAL.Intefaces;

public interface IUpdateNumber
{
    public void UpdateNumber(Counter recordNumber);
    public Task<Counter> GetNumberByIdAsync(int numberId);
    public Task SaveAsync();
}
