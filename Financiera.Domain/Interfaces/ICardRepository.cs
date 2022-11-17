﻿using Financiera.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Domain.Interfaces
{
    public interface ICardRepository : IRepository<Card>
    {
        Task<int> InsertCard(Card entity);
        Task<bool> UpdateCard(Card entity, int id);
        Task<bool> DeleteCard(int id);
        Card GetCardByDni(string dni);
        DataTable GetCards();
        Client GetClientByDni(string dni);
    }
}
