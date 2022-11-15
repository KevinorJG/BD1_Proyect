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
        Task<int> InsertAccount(Account entity);
        Task<bool> UpdateAccount(Account entity, int id);
        Task<bool> DeleteAccount(int id);
        Account GetAccountByDni(string dni);
        DataTable GetAccounts();
    }
}
