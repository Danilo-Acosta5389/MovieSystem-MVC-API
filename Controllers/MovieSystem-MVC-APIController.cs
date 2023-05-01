using Microsoft.AspNetCore.Mvc;
using MovieSystem_MVC_API.Data;

namespace MovieSystem_MVC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MovieSystem_MVC_APIController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public MovieSystem_MVC_APIController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var person = await repository.Get(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }
            await repository.Update(person);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity person)
        {
            await repository.Add(person);
            return CreatedAtAction("Get", new { id = person.Id }, person);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var person = await repository.Delete(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

    }

}
