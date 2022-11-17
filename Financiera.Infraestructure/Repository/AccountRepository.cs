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
    public class AccountRepository : IAccountRepository
    {
        private readonly IFinancieraContext Db;

        public AccountRepository(IFinancieraContext db)
        {
            Db = db;
        }

        public async Task<bool> DeleteAccount(int id)
        {
            return await Db.DeleteAccount(id);
        }

        public Account GetAccountByDni(string dni)
        {
            return Db.GetAccountByDni(dni);
        }

        public DataTable GetAccounts()
        {
            return Db.GetAccounts();
        }

        public async Task<int> InsertAccount(Account entity)
        {
            return await Db.InsertAccount(entity);
        }

        public async Task<bool> UpdateAccount(Account entity, int id)
        {
            return await Db.UpdateAccount(entity, id);
        }
        public Client GetClientByDni(string dni)
        {
            return Db.GetClientByDni(dni); ;
        }
    }
}
