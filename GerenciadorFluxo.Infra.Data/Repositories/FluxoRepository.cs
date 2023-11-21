using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;
using GerenciadorFluxo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorFluxo.Infra.Data.Repositories
{
    public class FluxoRepository : IFluxoRepository
    {
        private readonly ApplicationDbContext _context;

        public FluxoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Fluxo>> GetAllAsync()
        {
            return await _context.Fluxos
                .Include(f => f.Processos)
                .OrderByDescending(f => f.Id)
                .ToListAsync();
        }

        public async Task<Fluxo> GetByIdAsync(int id)
        {
            return await _context.Fluxos
                .Include(f => f.Processos)
                .SingleAsync(f => f.Id == id);
        }

        public async Task CreateAsync(Fluxo entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Fluxo entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Fluxo entity = await this.GetByIdAsync(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}