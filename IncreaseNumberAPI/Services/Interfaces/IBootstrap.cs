using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IBootstrap
{
    public Task<IEnumerable<NumberDTO>> Bootsrap(int count);
}
