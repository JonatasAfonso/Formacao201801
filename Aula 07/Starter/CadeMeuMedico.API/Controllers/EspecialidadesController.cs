using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadeMeuMedico.API;
using CadeMeuMedico.API.Model;

namespace CadeMeuMedico.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Especialidades")]
    public class EspecialidadesController : Controller
    {
        private readonly CadeMeuMedicoDb _context;

        public EspecialidadesController(CadeMeuMedicoDb context)
        {
            _context = context;
        }

        // GET: api/Especialidades
        [HttpGet]
        public IEnumerable<Especialidade> GetEspecialidades()
        {
            return _context.Especialidades;
        }

        // GET: api/Especialidades/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEspecialidade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var especialidade = await _context.Especialidades.SingleOrDefaultAsync(m => m.Id == id);

            if (especialidade == null)
            {
                return NotFound();
            }

            return Ok(especialidade);
        }

        // PUT: api/Especialidades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecialidade([FromRoute] int id, [FromBody] Especialidade especialidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != especialidade.Id)
            {
                return BadRequest();
            }

            _context.Entry(especialidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidadeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Especialidades
        [HttpPost]
        public async Task<IActionResult> PostEspecialidade([FromBody] Especialidade especialidade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Especialidades.Add(especialidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialidade", new { id = especialidade.Id }, especialidade);
        }

        // DELETE: api/Especialidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspecialidade([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var especialidade = await _context.Especialidades.SingleOrDefaultAsync(m => m.Id == id);
            if (especialidade == null)
            {
                return NotFound();
            }

            _context.Especialidades.Remove(especialidade);
            await _context.SaveChangesAsync();

            return Ok(especialidade);
        }

        private bool EspecialidadeExists(int id)
        {
            return _context.Especialidades.Any(e => e.Id == id);
        }
    }
}