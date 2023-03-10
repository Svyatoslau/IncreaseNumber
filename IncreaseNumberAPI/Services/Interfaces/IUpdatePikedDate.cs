using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IUpdatePikedDate
{
    public Task<CounterDto> UpdatePikedDateAsync(int id, DateTime dateTime);
}
