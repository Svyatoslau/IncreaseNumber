using AutoMapper;
using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Models.DTO;
using IncreaseNumberAPI.Services.Interfaces;

namespace IncreaseNumberAPI.Services;

public class UpdateDateService : IUpdatePikedDate
{
    private readonly ICounterUpdate _repository;
    private readonly Mapper _mapper;
    public UpdateDateService(ICounterRepository repository, CounterMapper mapper) =>
        (_repository, _mapper)= (repository, mapper);

    public async Task<CounterDto> UpdatePikedDateAsync(int id, DateTime dateTime)
    {
        Console.WriteLine(dateTime);

        var counter = await _repository.GetCounterByIdAsync(id);
        if (counter is null)
            return null;

        counter.PickedDate = dateTime;
        counter.LastChange = DateTime.Now;

        _repository.UpdateCounter(counter);
        await _repository.SaveAsync();

        return _mapper.Map<CounterDto>(counter);
    }
}
