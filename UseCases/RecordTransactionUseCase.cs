using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.ProductUseCase;
using UseCases.UseCaseInterfaces;

namespace UseCases
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly IGetProductIdByUseCase getProductIdByUseCase;

        public RecordTransactionUseCase(
            ITransactionRepository transactionRepository,
            IGetProductIdByUseCase getProductIdByUseCase)
        {
            this.transactionRepository = transactionRepository;
            this.getProductIdByUseCase = getProductIdByUseCase;
        }

        public IGetProductIdByUseCase GetProductIdByUseCase { get; }

        public void Execute(string cashierName, int productId, int qty)
        {
            var product = getProductIdByUseCase.Execute(productId);

            transactionRepository.Save(cashierName, productId,product.Name, product.Price.Value, product.Quantity.Value, qty);
        }
    }
}
