using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}