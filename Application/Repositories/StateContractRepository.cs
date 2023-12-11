using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class StateContractRepository : GenericRepository<StateContract>, IStateContract
    {
        private readonly BioseguridadContext _context;

        public StateContractRepository(BioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}