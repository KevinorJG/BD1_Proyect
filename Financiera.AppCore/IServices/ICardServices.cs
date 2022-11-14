using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera.Domain.Entities;

namespace Financiera.AppCore.IServices
{
    public interface ICardServices : IService<Card>
    {
        Task<int> Save(Card client);
        Client GetCardByDni(string dni);
        Task<bool> UpdateCard(Card entity, int id);
        DataTable GetCards();
        Client GetClientByDni(string dni);
    }
}
