﻿using AutoMapper;
using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL.Entities;
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
    public async Task<IEnumerable<NumberDTO>> Load(int count = 2)
    {
        var numbers = await _repository.GetNumbers(count);

        if (numbers.Count() < 1)
            return null;

        return _mapper.Map<IEnumerable<RecordNumber>, IEnumerable<NumberDTO>>(numbers);
    }
}
