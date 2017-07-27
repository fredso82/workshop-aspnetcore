using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPIApplication.Controllers
{
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        private readonly DataContext _context;

        public PessoasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ObterPessoas()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            return Json(pessoas);
        }

        [HttpPost]
        public async Task<IActionResult> IncluirPessoa([FromBody]Pessoa modelo)        
        {
            await _context.Pessoas.AddAsync(modelo);
            await _context.SaveChangesAsync();

            return Json(modelo);
        }

    }
}