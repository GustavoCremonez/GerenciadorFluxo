using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;
using GerenciadorFluxo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorFluxo.Infra.Data.Repositories
{
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProcessoRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<Processo> GetAsync(int id)
        {
            return await _context.Processos.SingleAsync(p => p.Id == id);
        }

        public async Task<List<Processo>> GetByFluxoAsync(int idFluxo)
        {
            return await _context.Processos
                .Include(p => p.Anotacoes)
                .Where(p => p.IdFluxo == idFluxo)
                .OrderByDescending(p => p.Id)
                .ToListAsync();
        }

        public async Task CreateAsync(Processo entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Processo entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Processo entity = await this.GetAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}