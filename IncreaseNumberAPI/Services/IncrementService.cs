using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Models.API;
using IncreaseNumberAPI.Models.DTO;
using IncreaseNumberAPI.Services.Interfaces;

namespace IncreaseNumberAPI.Services;

public class IncrementService : IIncrement
{
    private readonly IUpdateNumber _repository;
    private readonly NumberMapper _mapper;

    public IncrementService(INumberRepository repository, NumberMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);

    public async Task<NumberDto> Add(Increment increment, int id)
    {
        var number = await _repository.GetNumberById(id);
        if (number is null)
            return null;

        number.Value += increment.value;
        number.LastChange = DateTime.Now;

        _repository.UpdateNumber(number);
        await _repository.Save();

        var numberDto = _mapper.Map<NumberDto>(number);

        return numberDto;
    }
}
