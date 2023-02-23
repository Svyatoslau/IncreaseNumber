using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IBootstrap
{
    public Task<List<CounterDto>> Load(int count = 2);
}
