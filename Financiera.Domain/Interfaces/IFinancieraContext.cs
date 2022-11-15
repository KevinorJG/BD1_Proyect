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


        Task<int> InsertCard(Card entity);
        Task<bool> UpdateCard(Card entity, int id);
        Task<bool> DeleteCard(int id);
        Card GetCardByDni(string dni);
        DataTable GetCards();

        Task<int> InsertAccount(Account entity);
        Task<bool> UpdateAccount(Account entity, int id);
        Task<bool> DeleteAccount(int id);
        Account GetAccountByDni(string dni);
        DataTable GetAccounts();

    }
}
