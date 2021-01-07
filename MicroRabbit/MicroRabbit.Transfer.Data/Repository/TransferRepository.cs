using System;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _tranferDbContext;

        public TransferRepository(TransferDbContext tranferDbContext)
        {
            _tranferDbContext = tranferDbContext;
        }

        public void Add(TransferLog transferLog)
        {
            _tranferDbContext.Add(transferLog);
            
            _tranferDbContext.SaveChanges();  
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _tranferDbContext.TransferLogs;
        }
    }
}
