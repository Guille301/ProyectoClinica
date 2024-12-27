﻿using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private readonly IAltaPaciente _altaPaciente;
        private readonly ICUListarPaciente _ListarPaciente;
        private readonly ICUListarPacienteCI _CUListarPacienteCI;
        private readonly ICUListarPacienteNombre cUListarPacienteNombre;

        public PacienteController(IAltaPaciente altaPaciente, ICUListarPaciente listarPaciente, ICUListarPacienteCI cUListarPacienteCI, ICUListarPacienteNombre cUListarPacienteNombre)
        {
            _altaPaciente = altaPaciente;
            _ListarPaciente = listarPaciente;
            _CUListarPacienteCI = cUListarPacienteCI;
            this.cUListarPacienteNombre = cUListarPacienteNombre;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(PacienteAltaDto altaPacienteDto)
        {
            try
            {
                _altaPaciente.Ejecutar(altaPacienteDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }


        [HttpGet]
        [Authorize]
        public IActionResult GetPacientes()
        {

            try
            {

                return Ok(_ListarPaciente.ListarPacientes());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Ocurrió un error inesperado: " + ex.Message });
            }
        }




        [HttpGet]
        [Authorize]
        public IActionResult ObtenerPacienteCI(string ci)
        {

            try
            {
                PacienteDto dto = _CUListarPacienteCI.obtenerPacienteCi(ci);
                return Ok(dto);//TODO
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }





        }


        [HttpGet]
        [Authorize]
        public IActionResult ObtenerPacienteNombre(string nombre)
        {

            try
            {
                PacienteDto dto = cUListarPacienteNombre.ObtenerPacientePorNombre(nombre);
                return Ok(dto);//TODO
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }





        }











        // PUT api/<PacienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
