﻿using IncreaseNumberAPI.Models.API;
using IncreaseNumberAPI.Models.DTO;

namespace IncreaseNumberAPI.Services.Interfaces;

public interface IIncrement
{
    public Task<CounterDto> Add(Increment increment, int id);
}
