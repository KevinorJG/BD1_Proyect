using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IFinancieraContext Db;

        public AccountRepository(IFinancieraContext db)
        {
            Db = db;
        }
    }
}
