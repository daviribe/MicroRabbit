using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;

        public TransferService(ITransferRepository transferRespository, IEventBus eventBus)
        {
            _transferRepository = transferRespository;
            _eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTranferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
