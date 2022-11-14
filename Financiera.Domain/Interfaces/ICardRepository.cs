using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface ICardRepository : IRepository<Card>
    {
        Task<int> Save(Card client);
        Client GetCardByDni(string dni);
        Task<bool> UpdateCard(Card entity, int id);
        DataTable GetCards();
        Client GetClientByDni(string dni);
    }
}
