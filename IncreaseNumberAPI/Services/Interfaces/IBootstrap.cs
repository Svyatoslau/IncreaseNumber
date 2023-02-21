using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IBootstrap
{
    public Task<IEnumerable<NumberDto>> Load(int count = 2);
}
