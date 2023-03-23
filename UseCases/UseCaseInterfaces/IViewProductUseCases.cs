using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductUseCases
    {
        IEnumerable<Product> Execute();
    }
}