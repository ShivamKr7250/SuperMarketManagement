﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDate(string cashierName, DateTime date);
        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty);
    }
}
