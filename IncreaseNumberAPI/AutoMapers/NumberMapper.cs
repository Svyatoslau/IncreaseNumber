using AutoMapper;
using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.Models.DTO;
using System.Runtime.CompilerServices;

namespace IncreaseNumberAPI.AutoMapers;

public class NumberMapper : Mapper
{
    private static MapperConfiguration configNumberDTO =
        new MapperConfiguration(cfg => cfg.CreateMap<RecordNumber, NumberDTO>()
        .ForMember("Id", opt => opt.MapFrom(r => r.Id))
        .ForMember("Number", opt => opt.MapFrom(r => r.Number)));

    public NumberMapper() : base(configNumberDTO) { }
}
