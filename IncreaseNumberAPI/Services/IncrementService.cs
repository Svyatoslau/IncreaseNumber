using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Models.API;
using IncreaseNumberAPI.Models.DTO;
using IncreaseNumberAPI.Services.Interfaces;

namespace IncreaseNumberAPI.Services;

public class IncrementService : IIncrement
{
    private readonly ICounterUpdate _repository;
    private readonly CounterMapper _mapper;

    public IncrementService(ICounterRepository repository, CounterMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);

    public async Task<CounterDto> Add(Increment increment, int id)
    {
        var counter = await _repository.GetCounterByIdAsync(id);
        if (counter is null)
            return null;

        counter.Value += increment.value;
        counter.LastChange = DateTime.Now;

        _repository.UpdateCounter(counter);
        await _repository.SaveAsync();

        var counterDto = _mapper.Map<CounterDto>(counter);

        return counterDto;
    }
}
