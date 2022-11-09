using Financiera.Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<int> Save(Client client);
        Client GetClientByDni(string dni);
        Task<bool> UpdateClient(Client entity,int id);
        DataTable GetClients();
    }
}
