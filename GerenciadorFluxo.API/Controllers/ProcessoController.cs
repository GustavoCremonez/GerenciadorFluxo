using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFluxo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessoController : Controller
    {
        private readonly IProcessoService _processoService;

        public ProcessoController(IProcessoService processoService)
        {
            _processoService = processoService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                ProcessoDto processo = await _processoService.GetAsync(id);
                return Ok(processo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetByFluxo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetByFluxo(int id)
        {
            try
            {
                RetornoProcessosDto processos = await _processoService.GetByFluxoAsync(id);

                return Ok(processos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(ProcessoDto dto)
        {
            try
            {
                await _processoService.CreateAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(ProcessoDto dto)
        {
            try
            {
                await _processoService.UpdateAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _processoService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}