using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using ChamadosSetor8.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.Repositories
{
    public class ChurchRepository : RepositoryBase<Church>, IChurchRepository
    {
        public ChurchRepository(Sector8CallsContext context) : base(context) { }

    }
}
