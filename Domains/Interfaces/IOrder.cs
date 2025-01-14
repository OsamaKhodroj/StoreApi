using CompanyX.Store.Domains.Entites;

namespace CompanyX.Store.Domains.Interfaces
{
    public interface IOrder
    {
        Task<OrderStatus> Add(Order order);
    }
}
