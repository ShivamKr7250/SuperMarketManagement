using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases.TransactionsUseCase
{
    public class GetTodayTranscationUseCase : IGetTodayTranscationUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTodayTranscationUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName)
        {
            return transactionRepository.GetByDate(cashierName, DateTime.Now);
        }
    }
}
