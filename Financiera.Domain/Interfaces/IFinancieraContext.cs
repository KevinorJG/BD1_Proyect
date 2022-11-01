using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface IFinancieraContext
    {
        Task<int> InsertClient(Client entity);
        Task<bool> UpdateClient(Client entity);
        Task<bool> DeleteClient(int id);
        Task<int> GetClientByDni(string dni);
    }
}
