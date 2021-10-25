using System.Linq;
using System.Threading.Tasks;
using Competition_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Competition_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Jogos[]> GetAllJogosAsync(bool includeJogo = false)
        {
            IQueryable<Jogos> query = _context.Jogo;

            if (includeJogo)
            {
                query = query.Include(pe => pe.Jogo);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }
        public async Task<Jogos> GetJogoAsyncById(string JogosId, bool includeJogo)
        {
            IQueryable<Jogos> query = _context.Jogo;


            {
                query = query.Include(a => a.Jogo);
            }

            query = query.AsNoTracking()
                         .OrderBy(jogos => jogos.id)
                         .Where(Jogos => Jogos.id == JogosId);

            return await query.FirstOrDefaultAsync();
        }

    }
}



