﻿using System.Linq;

using OrdBase.Models;
using OrdBase.IData;

namespace OrdBase.Services
{
    public class ClientRepository : IClientData
    {
        private readonly TranslationDb _context;
        public ClientRepository(TranslationDb context)
        {
            _context = context;
        }

        public Client[] Get(string name) 
        {
        	return (from c in _context.Client
        			where c.Name == name
        			select c)
        				.ToArray();
        } 

        public Client[] GetAll() 
        {
        	return _context.Client.ToArray();
        }
    }
}