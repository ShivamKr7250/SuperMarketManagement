using CoreBusiness;

namespace UseCases.ProductUseCase
{
    public interface IGetProductIdByUseCase
    {
        Product Execute(int productId);
    }
}