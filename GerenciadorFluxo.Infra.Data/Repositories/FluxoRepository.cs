using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Domain.Entities;
using GerenciadorFluxo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GerenciadorFluxo.Infra.Data.Repositories
{
    public class FluxoRepository : IFluxoRepository
    {
        private readonly ApplicationDbContext _context;

        public FluxoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Fluxo>> GetAllAsync()
        {
            return await _context.Fluxos.ToListAsync();
        }

        public async Task<Fluxo> GetByIdAsync(int id)
        {
            return await _context.Fluxos.SingleAsync(f => f.Id == id);
        }

        public async Task<int> CreateAsync(Fluxo entity)
        {
            Fluxo createdEntity = _context.Add(entity).Entity;
            await _context.SaveChangesAsync();

            return createdEntity.Id;
        }

        public async Task<int> UpdateAsync(Fluxo entity)
        {
            Fluxo updatedEntity = _context.Update(entity).Entity;
            await _context.SaveChangesAsync();

            return updatedEntity.Id;
        }

        public async Task DeleteAsync(int id)
        {
            Fluxo entity = await _context.Fluxos.SingleAsync(f => f.Id == id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}