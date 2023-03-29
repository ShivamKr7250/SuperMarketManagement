using CoreBusiness;

namespace UseCases
{
    public interface IGetTodayTranscationUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}