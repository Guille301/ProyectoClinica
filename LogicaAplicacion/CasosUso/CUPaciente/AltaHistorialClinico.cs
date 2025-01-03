using DTOs.HistorialClinico;
using DTOs.Mappers;
using DTOs.Paciente;
using LogicaAplicacion.InterfaceCasosUso.ICUPaciente;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LogicaAplicacion.CasosUso.CUPaciente
{
    public class AltaHistorialClinico:ICUAltaHistorialClinico
    {
        IRepositorioHistorialesClinicos _repoHistorialesClinicos;
        IRepositorioPacientes _repositorioPacientes;
        public AltaHistorialClinico(IRepositorioHistorialesClinicos repositorioHistorialesClinicos)
        {
            _repoHistorialesClinicos = repositorioHistorialesClinicos;
        }



        public DtoAltaHistorialClinico FichaHistorialClinico(int id)
        {
            DtoAltaHistorialClinico retorno = new DtoAltaHistorialClinico();

            Pacientes pacienteBuscado = _repositorioPacientes.FindById(id);
            PacienteDto dtoPaciente = PacienteMappers.FromPacienteToDtoPaciente(pacienteBuscado);

            retorno.Paciente = dtoPaciente;
            return retorno;
        }

        public void AltaHistorialCl(DtoAltaHistorialClinico dto)
        {
            try 
            {
                if (dto.RazonDeConsulta != null || dto.ExamenFisico != null || dto.Diagnostico != null
                   || dto.Antecedentes != null || dto.HabitosPSB != null || dto.ImagenLaboratorio != null
                  || dto.Tratamiento != null)
                {
                    HistorialesClinicos nuevo = HistorialClinicoMapper.DtoHistorialClinicoToHisorialClinico(dto);
                    _repoHistorialesClinicos.Add(nuevo);
                }
                else if (dto.RazonDeConsulta == null || dto.ExamenFisico == null || dto.Diagnostico == null
                    || dto.Antecedentes == null || dto.HabitosPSB == null || dto.ImagenLaboratorio == null
                   || dto.Tratamiento == null)
                {
                    throw new NotImplementedException();//TODO
                }
            }
            catch(Exception ex)  
            {
                throw new Exception($"A ocurrido un error  al realizar la consulta:{ex.Message}",ex);
            }


            
        }


    }
}
