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
        Task<int> InsertCard(Card entity);       
        Task<bool> DeleteCard(int id);
        Card GetCardByDni(string dni);
        DataTable GetCards();
        Client GetClientByDni(string dni);
    }
}
