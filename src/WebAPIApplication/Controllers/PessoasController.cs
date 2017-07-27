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
        public async Task<IActionResult> GetPessoas()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            return Json(pessoas);

        }

    }
}