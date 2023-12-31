﻿using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class City
{
    public int Id { get; set; }

    public string NameCity { get; set; }

    public int IdStateFk { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual State IdStateFkNavigation { get; set; }
}
