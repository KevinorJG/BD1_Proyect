using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.AppCore.IServices
{
    public interface IClientServices : IService<Client>
    {
        Task<int> Save(Client client);

    }
}
