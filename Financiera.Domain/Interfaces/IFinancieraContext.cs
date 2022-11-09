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


    }
}
