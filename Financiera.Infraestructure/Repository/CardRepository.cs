using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructure.Repository
{
    public class CardRepository : ICardRepository
    {
        protected readonly IFinancieraContext Db;

        public CardRepository(IFinancieraContext db)
        {
            Db = db;
        }
    }
}
