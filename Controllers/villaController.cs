using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica.Datos;
using Prueba_Tecnica.Modelos;
using Prueba_Tecnica.Modelos.Dto;
namespace Prueba_Tecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class villaController : ControllerBase
    {      
        private readonly ILogger<villaController> _logger;
        private readonly ApplicationDbContext _db;
        public villaController(ILogger<villaController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVilla(int id)
        {

            _logger.LogInformation("Obtener las villas");
            return Ok(_db.Villas.ToList());

        }

        [HttpGet("id:int", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDto> GetVillaDto(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Error al traer Villa con Id " + id);
                return BadRequest();
            }
         //   var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
         var villa =_db.Villas.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound("No hay ningún registro con ese ID");
            }

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public ActionResult<VillaDto>CrearVilla([FromBody] VillaDto villaDto)

        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(_db.Villas.FirstOrDefault(v=>v.Nombre.ToLower() == villaDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "La villa con ese Nombre ya Existe");
                return BadRequest(ModelState);
            }
            if(villaDto == null)
            {
                return BadRequest(villaDto);
            }
            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa modelo = new()
            {
                Nombre = villaDto.Nombre,
                Detalle = villaDto.Detalle,
                ImageUrl = villaDto.ImageUrl,
                Ocupantes = villaDto.Ocupantes,
                Tarifa = villaDto.Tarifa,
                MetrosCuadrados = villaDto.MetrosCuadrados,
                Amenidad = villaDto.Amenidad
            };
            _db.Villas.Add(modelo);
            _db.SaveChanges();
            return CreatedAtRoute("GetVilla", new {id= villaDto.Id}, villaDto);
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa= _db.Villas.FirstOrDefault(V=>V.Id==id);
            if (villa != null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            _db.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDto villaDto)
        {
            if(villaDto== null || id!=villaDto.Id)
            {
                return BadRequest();
            }
            //var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            //villa.Nombre = villaDto.Nombre;
            //villa.Ocupantes = villaDto.Ocupantes;
            //villa.MetrosCuadrados=villaDto.MetrosCuadrados;

            Villa modelo = new()
            {
                Id = villaDto.Id,
                Nombre = villaDto.Nombre,
                Detalle = villaDto.Detalle,   
                ImageUrl = villaDto.ImageUrl,
                Ocupantes = villaDto.Ocupantes,
                Tarifa  = villaDto.Tarifa,  
                MetrosCuadrados = villaDto.MetrosCuadrados,
                Amenidad = villaDto.Amenidad

            };

        _db.Villas.Update(modelo);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla(int id,JsonPatchDocument<VillaDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }
            //var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            var villa= _db.Villas.AsNoTracking().FirstOrDefault(v=>v.Id==id);

            VillaDto villaDto = new()
            {
                Id = villa.Id,
                Nombre = villa.Nombre,
                Detalle = villa.Detalle,
                ImageUrl = villa.ImageUrl,
                Ocupantes = villa.Ocupantes,
                Tarifa = villa.Tarifa,
                MetrosCuadrados = villa.MetrosCuadrados,
                Amenidad = villa.Amenidad

            };
            if (villa == null) return BadRequest();
            patchDto.ApplyTo(villaDto, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Villa modelo = new()
            {
                Id = villaDto.Id,
                Nombre = villaDto.Nombre,
                Detalle = villaDto.Detalle,
                ImageUrl = villaDto.ImageUrl,
                Ocupantes = villaDto.Ocupantes,
                Tarifa = villaDto.Tarifa,
                MetrosCuadrados = villaDto.MetrosCuadrados,
                Amenidad = villaDto.Amenidad
            };
            _db.Villas.Update(modelo);
            _db.SaveChanges();
            return NoContent();
        }
    }
}
