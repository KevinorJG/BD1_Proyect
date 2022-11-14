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

        public Client GetCardByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCards()
        {
            return repository.GetCards();
        }

        public Client GetClientByDni(string dni)
        {
           return repository.GetClientByDni(dni);
        }

        public async Task<int> Save(Card client)
        {
           return await repository.Save(client);
        }

        public Task<bool> UpdateCard(Card entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
