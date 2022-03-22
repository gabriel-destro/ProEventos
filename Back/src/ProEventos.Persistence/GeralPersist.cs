using System.Threading.Tasks;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly ProEventosContext _contex;
        public GeralPersist(ProEventosContext contex)
        {
            _contex = contex;

        }
        public void Add<T>(T entity) where T : class
        {
            _contex.Add(entity);
        }
         public void Update<T>(T entity) where T : class
        {
            _contex.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _contex.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _contex.RemoveRange(entityArray);
        }

         public async Task<bool> SaveChangesAsync()
        {
            return (await _contex.SaveChangesAsync()) > 0;
        }
    }
}