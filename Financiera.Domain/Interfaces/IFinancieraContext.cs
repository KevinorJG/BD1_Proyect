using Financiera.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface IFinancieraContext
    {
        Task<int> InsertClient(Client entity);
        Task<bool> UpdateClient(Client entity,int id);
        Task<bool> DeleteClient(int id);
        Client GetClientByDni(string dni);
        DataTable GetClients();


        Task<int> InsertCard(Card entity, string identi);
        Task<bool> DeleteCard(int id);
        DataTable GetCardsByDni(string dni);
        DataTable GetCards();

        Task<int> InsertAccount(Account entity);
        Task<bool> DeleteAccount(int id);
        DataTable GetAccountsByDni(string dni);
        DataTable GetAccounts();

    }
}
