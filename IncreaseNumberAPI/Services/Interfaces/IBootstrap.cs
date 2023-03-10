using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IBootstrap
{
    public Task<List<CounterDto>> LoadAsync(int count = 2);
}
