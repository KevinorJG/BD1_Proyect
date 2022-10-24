using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
      Task<int> Save(Client client);
    }
}
