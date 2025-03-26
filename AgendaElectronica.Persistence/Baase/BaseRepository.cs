

using AgendaElectronica.Domain.Repositories;
using AgendaElectronica.Domain.Result;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AgendaElectronica.Persistence.Baase
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        private readonly AgendaElectronicaContext _context;
        private DbSet<TEntity> entities;

        public BaseRepository(AgendaElectronicaContext context)
        {
            _context = context;
            this.entities = _context.Set<TEntity>();
        }

        public virtual async Task<OperationResult> Add(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try 
            {
                entities.Add(entity);
                await _context.SaveChangesAsync();
                result.success = true;
            }
            catch (Exception ex) 
            {
                result.success = false;
                result.message = $"Ocurrio un error {ex} obteniendo la entidad";
            }
            return result;
            
        }

        public virtual async Task<OperationResult> Delete(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Remove(entity);
                await _context.SaveChangesAsync();
                result.success = true;
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = $"Ocurrio un error {ex} eliminando los datos";
            }
            return result;
        }

        public virtual async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await this.entities.AnyAsync(filter);
        }

        public virtual async Task<OperationResult> GetAll()
        {
            OperationResult result = new OperationResult();

            try 
            {
                var data = await entities.ToListAsync();
                result.Data = data;

                result.success = true;
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = $"Ocurrio un error {ex} obteniendo los datos";
            }
            return result;
        }

        public virtual async Task<OperationResult> GetById(int id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var data = await entities.FindAsync(id);
                result.Data = data;
                result.success = true;
            }
            catch (Exception ex) 
            {
                result.success = false;
                result.message = $"Ocurrio un error {ex} obteniendo los datos";
            }
            return result;
        }

        public virtual async Task<OperationResult> Update(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Update(entity);
                await _context.SaveChangesAsync();
                result.success = true;
            }
            catch (Exception ex)
            {
                result.success= false;
                result.message = $"Ocurrio un error {ex} actualizando la informacion";
            }
            return result;
        }
    }
}
