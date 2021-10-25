using System.Threading.Tasks;
using Competition_WebAPI.Models;

namespace Competition_WebAPI.Data

{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Jogos
        Task<Jogos[]> GetAllJogosAsync(bool includeJogos);
        Task<Jogos> GetJogoAsyncById(string jogoId, bool includeJogos);

    }
}

