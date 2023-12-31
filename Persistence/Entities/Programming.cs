﻿using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Programming
{
    public int Id { get; set; }

    public int IdContractFk { get; set; }

    public int IdTurnFk { get; set; }

    public int IdEmployeeFk { get; set; }

    public virtual Contract IdContractFkNavigation { get; set; }

    public virtual Employee IdEmployeeFkNavigation { get; set; }

    public virtual Turn IdTurnFkNavigation { get; set; }
}
