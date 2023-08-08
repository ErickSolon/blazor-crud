using Projeto.Models;

namespace Projeto.Services
{
    public interface IPessoasService
    {
        Task Add(Pessoas pessoas);
        Task Update(Pessoas pessoas);
        Task Delete(Pessoas pessoas);
        Task<Pessoas> GetById(Guid id);
        Task<List<Pessoas>> FindAll();
    }
}