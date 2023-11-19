using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFluxo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes(contentType: "application/json")]
    public class FluxoController : ControllerBase
    {
        private readonly IFluxoService _fluxoService;

        public FluxoController(IFluxoService fluxoService)
        {
            _fluxoService = fluxoService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Fluxo entity = await _fluxoService.GetByIdAsync(id);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            try
            {
                ICollection<Fluxo> result = await _fluxoService.GetAllAsync();
                if (result.Any())
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(Fluxo entity)
        {
            try
            {
                int createdId = await _fluxoService.CreateAsync(entity);

                return CreatedAtAction("Get", new { id = createdId });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(Fluxo entity)
        {
            try
            {
                int updatedId = await _fluxoService.UpdateAsync(entity);

                return CreatedAtAction("Get", new { id = updatedId });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _fluxoService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}