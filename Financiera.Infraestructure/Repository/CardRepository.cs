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
    public class CardRepository : ICardRepository
    {
        protected IFinancieraContext Db;

        public CardRepository(IFinancieraContext db)
        {
            Db = db;
        }

        public Client GetCardByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCards()
        {
            return Db.GetCards();
        }

        public Client GetClientByDni(string dni)
        {
            return Db.GetClientByDni(dni);
        }

        public Task<int> Save(Card client)
        {
            return Db.InsertCard(client);
        }

        public Task<bool> UpdateCard(Card entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
