﻿using DTOs.HistorialClinico;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUHistoriaClinica;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClinicaMvc.Controllers
{
    public class HistoriaClinicaController : Controller
    {


        private readonly IPacienteFicha _fichaPaciente;
        private readonly IAgregrarHistoriaClinica _agregarHistoria;
        private readonly IEditarHistoriaClinica _editarHistoriaClinica;
        private readonly IListarHistoriaClinica _listarHistoriaClinica;

        public HistoriaClinicaController(
            IPacienteFicha pacienteFicha,
            IAgregrarHistoriaClinica agregarHistoria,
            IEditarHistoriaClinica editarHistoriaClinica,
            IListarHistoriaClinica listarHistoriaClinica)
        {
            _fichaPaciente = pacienteFicha;
            _agregarHistoria = agregarHistoria;
            _editarHistoriaClinica = editarHistoriaClinica;
            _listarHistoriaClinica = listarHistoriaClinica;
        }

        public IActionResult ObtenerFichaPaciente(int id, string motivoDeConsulta, string enfermedadActual, 
            string antecedentes, string habitosPSB, string examenFisico, string diagnostico, string examenLaboratorio, 
            string tratamiento, bool creandoHistorial)
        {
            try
            {
                if (id != 0 && creandoHistorial == true) 
                {
                    HistoriaAltaDto dto = new HistoriaAltaDto
                    {
                        PacienteId = id,
                        MotivoDeConsulta = motivoDeConsulta,
                        EnfermedadActual = enfermedadActual,
                        Antecedentes = antecedentes,
                        HabitosPSB = habitosPSB,
                        ExamenFisico = examenFisico,
                        Diagnostico = diagnostico,
                        ExameneLaboratorio = examenLaboratorio,
                        Tratamiento = tratamiento
                    };

                    FichaPacienteDto retorno2 = _fichaPaciente.obtenerFichaYAltaHistorialPaciente(dto);
                    return View(retorno2);
                }
                else 
                {
                    FichaPacienteDto retorno1 = _fichaPaciente.obtenerFichaPaciente(id);
                    return View(retorno1);
                }
                  
            }
            catch (Exception e)
            {
                return View("Error"); 
            }
        }



        public IActionResult Create(int PacienteId)
        {
            HistoriaAltaDto altaDto = new HistoriaAltaDto();
            altaDto.PacienteId = PacienteId;
            return View(altaDto);  
        }

        
        [HttpPost]
        public IActionResult Create(HistoriaAltaDto altaDto)
        {
            try
            {

                return RedirectToAction("ObtenerFichaPaciente", "HistoriaClinica", new
                {
                    id = altaDto.PacienteId,
                    motivoDeConsulta = altaDto.MotivoDeConsulta,
                    enfermedadActual = altaDto.EnfermedadActual,
                    antecedentes = altaDto.Antecedentes,
                    habitosPSB = altaDto.HabitosPSB,
                    examenFisico = altaDto.ExamenFisico,
                    diagnostico = altaDto.Diagnostico,
                    examenLaboratorio = altaDto.ExameneLaboratorio,
                    tratamiento = altaDto.Tratamiento,
                    creandoHistorial = true
                });
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Ocurrió un error inesperado: " + ex.Message;
                return View(altaDto); 
            }
        }

        
        //public IActionResult Edit(int id)
        //{
        //    try
        //    {
        //        var historia = _editarHistoriaClinica.Ejecutar(id);
        //        if (historia == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(historia);
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error");
        //    }
        //}

        // POST para procesar la edición
        [HttpPost]
        public IActionResult Edit(int id, EditarHistoriaDTO dto)
        {
            try
            {
                _editarHistoriaClinica.Ejecutar(dto, id);
                return RedirectToAction("GetHistoriaClinica", new { id });
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(dto);
            }
        }

        // Método para mostrar la lista de historias clínicas
        public IActionResult GetHistoriaClinica(int id)
        {
            try
            {
                var historias = _listarHistoriaClinica.ListarHistoria(id);
                return View(historias);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }








    }
}
