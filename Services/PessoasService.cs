using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Services
{
    public class PessoasService : IPessoasService
    {
        private readonly ProjetoDbContext _context;
        public PessoasService(ProjetoDbContext context)
        {
            _context = context;
        }

        public async Task Add(Pessoas pessoas)
        {
            await _context.AddAsync(pessoas);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Pessoas pessoas)
        {
            _context.Update(pessoas);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Pessoas pessoas)
        {
            _context.Remove(pessoas);
            await _context.SaveChangesAsync();
        }

        public async Task<Pessoas> GetById(Guid id)
        {
            var Dados = await _context.PessoasModel.FirstOrDefaultAsync(x => x.Id == id);
            return Dados;
        }

        public async Task<List<Pessoas>> FindAll()
        {
            var Dados = await _context.PessoasModel.ToListAsync();
            return Dados;
        }
    }
}