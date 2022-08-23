using Appendix_A_Assignement_6.Data;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace Appendix_A_Assignement_6.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class CharacterController : Controller
    {
        private MoviesDbContext _dbContext;

        public CharacterController(MoviesDbContext context)
        {
            _dbContext = context;
        }


        [HttpGet]
        public async Task<ActionResult<Character>> Get()
        {
            var character = _dbContext.Character.FirstOrDefault();

            return Ok(character);
        }
    }
}
