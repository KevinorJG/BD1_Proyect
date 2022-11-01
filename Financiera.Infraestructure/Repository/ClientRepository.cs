using Financiera.Domain.ContextDB;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task<int> GetClientByDni(string dni)
        {
            var result = Db.GetClientByDni(dni);
            return await result;
        }

        public async Task<int> Save(Client client)
        {
           var result = Db.InsertClient(client);
            return await result;
        }

        
    }
}
