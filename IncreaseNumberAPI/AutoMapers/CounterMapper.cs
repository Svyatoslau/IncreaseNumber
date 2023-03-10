using AutoMapper;
using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.Models.DTO;
using System.Runtime.CompilerServices;

namespace IncreaseNumberAPI.AutoMapers;

public class CounterMapper : Mapper
{
    private static MapperConfiguration configCounterDto =
        new MapperConfiguration(cfg => cfg.CreateMap<Counter, CounterDto>());

    public CounterMapper() : base(configCounterDto) { }
}
