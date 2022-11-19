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

        public async Task<bool> DeleteCard(int id)
        {
            return await repository.DeleteCard(id);
        }

        public Card GetCardByDni(string dni)
        {
           return repository.GetCardByDni(dni);
        }

        public DataTable GetCards()
        {
            return repository.GetCards();
        }

        public Client GetClientByDni(string dni)
        {
            return repository.GetClientByDni(dni);
        }

        public async Task<int> InsertCard(Card entity)
        {
            return await repository.InsertCard(entity);
        }

       
        
    }
}
