using AutoMapper;
using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.AutoMapers.Interfaces;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Models.DTO;
using IncreaseNumberAPI.Services.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace IncreaseNumberAPI.Services;

public class BootstrapService : IBootstrap
{
    private readonly INumberGetSliceData _repository;
    private readonly NumberMapper _mapper;
    public BootstrapService(INumberRepository repository, NumberMapper mapper) =>
        (_repository, _mapper) = (repository, mapper);
    public async IEnumerable<NumberDTO> Bootsrap(int count)
    {
        var numbers = await _repository.GetNumbers(count);

        if (numbers.Count() < 1)
            return null;

    }
}
