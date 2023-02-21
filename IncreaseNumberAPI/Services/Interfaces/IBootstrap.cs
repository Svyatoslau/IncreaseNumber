using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IBootstrap
{
    public Task<IEnumerable<NumberDTO>> Load(int count = 2);
}
