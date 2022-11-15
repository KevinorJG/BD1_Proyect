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
    public class CardServices : ICardServices
    {
        protected readonly ICardRepository repository;

        public CardServices(ICardRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> DeleteAccount(int id)
        {
            return await repository.DeleteAccount(id);
        }

        public Account GetAccountByDni(string dni)
        {
           return repository.GetAccountByDni(dni);
        }

        public DataTable GetAccounts()
        {
            return repository.GetAccounts();
        }

        public async Task<int> InsertAccount(Account entity)
        {
            return await repository.InsertAccount(entity);
        }

        public async Task<bool> UpdateAccount(Account entity, int id)
        {
            return await repository.UpdateAccount(entity, id);  
        }
    }
}
