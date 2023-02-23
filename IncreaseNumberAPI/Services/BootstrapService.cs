using AutoMapper;
using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Models.DTO;
using IncreaseNumberAPI.Services.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace IncreaseNumberAPI.Services;

public class BootstrapService : IBootstrap
{
    private readonly ICounterGetSliceData _repository;
    private readonly CounterMapper _mapper;
    public BootstrapService(ICounterRepository repository, CounterMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);
    public async Task<List<CounterDto>> Load(int count = 2)
    {
        var counters = await _repository.GetCountersAsync(count);

        if (counters.Count() < 1)
            return null;

        var countersDto = _mapper.Map<List<CounterDto>>(counters);

        return countersDto;
    }
}
