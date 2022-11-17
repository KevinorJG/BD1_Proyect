﻿using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera.Infraestructure.Repository
{
    public class CardRepository : ICardRepository
    {
        protected IFinancieraContext Db;

        public CardRepository(IFinancieraContext db)
        {
            Db = db;
        }

        public async Task<bool> DeleteCard(int id)
        {
           return await Db.DeleteCard(id);
        }

        public Card GetCardByDni(string dni)
        {
            return Db.GetCardByDni(dni);
        }

        public DataTable GetCards()
        {
           return Db.GetCards();
        }

        public async Task<int> InsertCard(Card entity)
        {
            return await Db.InsertCard(entity);
        }

        public async Task<bool> UpdateCard(Card entity, int id)
        {
           return await Db.UpdateCard(entity, id);
        }
        public Client GetClientByDni(string dni)
        {
            return Db.GetClientByDni(dni); ;
        }
    }
}
