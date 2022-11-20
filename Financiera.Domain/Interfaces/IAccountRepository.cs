using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<int> InsertAccount(Account entity);
        Task<bool> DeleteAccount(int id);
        DataTable GetAccountsByDni(string dni);
        DataTable GetAccounts();
        Client GetClientByDni(string dni);
    }
}
