using CompanyX.Store.Domains.Entites;

namespace CompanyX.Store.Domains.Interfaces
{
    public interface IProduct
    {
        void Add(Product product);
        void Delete(int id);
        Task<Task> GetById(int id);
        Task<List<Product>> GetAll();
        Task<List<Product>> Search(string query);
    }
}
