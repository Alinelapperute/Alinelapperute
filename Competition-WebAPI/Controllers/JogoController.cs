using System;
using System.Threading.Tasks;
using Competition_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace Competition_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogoController : ControllerBase
    {

        public JogoController(IRepository repo)
        {
            this.Repo = repo;
        }

        public IRepository Repo { get; }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await this.Repo.GetAllJogosAsync(true);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro na task Get() {ex.Message}");
            }
        }


        [HttpGet("{JogoId}")]

        public async Task<IActionResult> GetByJogoId(string JogoId)
        {
            try
            {
                var result = await this.Repo.GetJogoAsyncById(JogoId, false);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro na Task GetByJogoId {ex.Message}");
            }
        }
    }
}
