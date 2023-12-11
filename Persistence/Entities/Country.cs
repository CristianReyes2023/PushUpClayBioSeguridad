﻿using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string NameCountry { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
