﻿using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Addressoffice
{
    public int Id { get; set; }

    public string TipoVia { get; set; }

    public short? NumeroPrincipal { get; set; }

    public string LetraPrincipal { get; set; }

    public string Bis { get; set; }

    public string LetraSecundaria { get; set; }

    public string CardinalPrimario { get; set; }

    public short? NumeroSecundario { get; set; }

    public string CardinalSecundario { get; set; }

    public string Complemento { get; set; }

    public int IdEmployeeFk { get; set; }

    public int IdTaddressFk { get; set; }

    public virtual Employee IdEmployeeFkNavigation { get; set; }
}
