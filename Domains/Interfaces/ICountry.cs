using CompanyX.Store.Domains.Entites;

namespace CompanyX.Store.Domains.Interfaces
{
    public interface ICountry
    {
        void Add(Country country);
        void Delete(int id);
        Task<Country> GetById(int id);
        Task<List<Country>> GetAll(); 

    }
}
