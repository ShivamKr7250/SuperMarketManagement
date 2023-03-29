using UseCases.ProductUseCase;

namespace UseCases.UseCaseInterfaces
{
    public interface IRecordTransactionUseCase
    {
        IGetProductIdByUseCase GetProductIdByUseCase { get; }

        void Execute(string cashierName, int productId, int qty);
    }
}