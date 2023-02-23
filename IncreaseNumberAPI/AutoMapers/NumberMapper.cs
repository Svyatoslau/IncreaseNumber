using AutoMapper;
using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.Models.DTO;
using System.Runtime.CompilerServices;

namespace IncreaseNumberAPI.AutoMapers;

public class NumberMapper : Mapper
{
    private static MapperConfiguration configNumberDTO =
        new MapperConfiguration(cfg => cfg.CreateMap<Counter, NumberDto>());

    public NumberMapper() : base(configNumberDTO) { }
}
