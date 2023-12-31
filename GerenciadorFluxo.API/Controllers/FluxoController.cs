﻿using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Application.Dtos;
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
                FluxoDto entity = await _fluxoService.GetByIdAsync(id);

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
                ICollection<FluxoDto> result = await _fluxoService.GetAllAsync();
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
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(FluxoDto dto)
        {
            try
            {
                await _fluxoService.CreateAsync(dto);

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
        public async Task<IActionResult> Put(FluxoDto dto)
        {
            try
            {
                await _fluxoService.UpdateAsync(dto);

                return NoContent();
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