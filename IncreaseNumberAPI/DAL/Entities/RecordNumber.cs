﻿using System;
using System.Collections.Generic;

namespace IncreaseNumberAPI.DAL.Entities;

public partial class RecordNumber
{
    public int Id { get; set; }

    public int Number { get; set; }

    public DateTime LastChange { get; set; }
}