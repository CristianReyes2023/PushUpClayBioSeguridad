﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Client : BaseEntity
{

    public string IdClient { get; set; } = null!;

    public string NameCliente { get; set; } = null!;

    public DateTime DateRegister { get; set; }

    public string TelephoneNumber { get; set; } = null!;

    public int? IdTpersonFk { get; set; }

    public int? IdCityFk { get; set; }

    public virtual ICollection<AddressClient> AddressClients { get; set; } = new List<AddressClient>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual City IdCityFkNavigation { get; set; }

    public virtual TypePerson IdTpersonFkNavigation { get; set; }
}
