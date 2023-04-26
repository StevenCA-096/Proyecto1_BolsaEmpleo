using Microsoft.AspNetCore.Mvc;
using Proyecto1_BolsaEmpleo.Data;
using Proyecto1_BolsaEmpleo.Models;
using Proyecto1_BolsaEmpleo.RequestObjects;

namespace Proyecto1_BolsaEmpleo.Controllers
{
    public class HabilidadController : ControllerBase
    {

        private readonly MyApiContext _context;

        public HabilidadController(MyApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Formacion>> PostHabilidad(HabilidadVm habilidadRequest)
        {
            if (_context.Formacion == null)
            {
                return Problem("Entity set 'MyApiContext.Formacion'  is null.");
            }

            Formacion newFormacion = new Formacion();
            newFormacion.CandidatoId = formacionRequest.CandidatoId;
            newFormacion.Nombre = formacionRequest.Nombre;
            newFormacion.Años_Estudio = formacionRequest.Años_Estudio;
            newFormacion.Fecha_Culminacion = formacionRequest.Fecha_Culminacion;


            _context.Formacion.Add(newFormacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostFormacion", new { id = newFormacion.Id });
        }



    }
}
