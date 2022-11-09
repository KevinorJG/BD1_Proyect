using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera.AppCore.IServices;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;

namespace Financiera.AppCore.Services
{
    public class ClientService : IClientServices
    {
        protected readonly IClientRepository repository;

        public ClientService(IClientRepository repository)
        {
            this.repository = repository;
        }

        public Client GetClientByDni(string dni)
        {
            return repository.GetClientByDni(dni);
        }

        public DataTable GetClients()
        {
            return repository.GetClients();
        }

        public async Task<int> Save(Client client)
        {
          return await repository.Save(client);
        }

        public async Task<bool> UpdateClient(Client entity, int id)
        {
            return await repository.UpdateClient(entity,id);
        }
    }
}
