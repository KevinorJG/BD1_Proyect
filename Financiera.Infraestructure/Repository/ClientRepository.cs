using Financiera.Domain.ContextDB;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructure.Repository
{
   public class ClientRepository : IClientRepository
   {
        protected IFinancieraContext Db;

        public ClientRepository(IFinancieraContext db)
        {
            Db = db;
        }

        public Client GetClientByDni(string dni)
        {         
            return  Db.GetClientByDni(dni); ;
        }

        public DataTable GetClients()
        {
           return Db.GetClients();
        }

        public async Task<int> Save(Client client)
        {
            return await Db.InsertClient(client);
        }

        public async Task<bool> UpdateClient(Client entity, int id)
        {
           return await Db.UpdateClient(entity,id);
        }
    }
}
