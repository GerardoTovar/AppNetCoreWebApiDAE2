using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppNetCoreWebApiDAE2.Data;
using Newtonsoft.Json;

//Librerias extra
using AppNetCoreWebApiDAE2.Models;
using Microsoft.EntityFrameworkCore;

namespace AppNetCoreWebApiDAE2.Controllers
{
    [Route("api/")]
    [ApiController]
    public class FicPersonasController : ControllerBase
    {
        private readonly FicDBContext FicLoDBContext;
        public FicPersonasController(FicDBContext FicPaDBContext)
        {
            FicLoDBContext = FicPaDBContext;
        }


        //---------------------------GET DATA CATALOGOS--------------------------------//


        [HttpGet("GetEvaCatCarreras")]
        public ContentResult FicGetListEvaCatCarreras()
        {
            var FicResult = from per in FicLoDBContext.eva_cat_carreras select per;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatTiposEstatus")]
        public ContentResult FicGetListCatTiposEstatus()
        {
            var FicResult = from dom in FicLoDBContext.cat_tipos_estatus select dom;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatEstatus")]
        public ContentResult FicGetListCatEstatus()
        {
            var FicResult = from tel in FicLoDBContext.cat_estatus select tel;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatTiposGenerales")]
        public ContentResult FicGetListCatTiposGenerales()
        {
            var FicResult = from perper in FicLoDBContext.cat_tipos_generales select perper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatGenerales")]
        public ContentResult FicGetListCatGenerales()
        {
            var FicResult = from alu in FicLoDBContext.cat_generales select alu;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatPaises")]
        public ContentResult FicGetListCatPaises()
        {
            var FicResult = from emp in FicLoDBContext.cat_paises select emp;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatMunicipios")]
        public ContentResult FicGetListCatMunicipios()
        {
            var FicResult = from cat in FicLoDBContext.cat_municipios select cat;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatEstados")]
        public ContentResult FicGetListCatEstados()
        {
            var FicResult = from dirw in FicLoDBContext.cat_estados select dirw;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatLocalidades")]
        public ContentResult FicGetListCatLocalidades()
        {
            var FicResult = from perperest in FicLoDBContext.cat_localidades select perperest;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatColonias")]
        public ContentResult FicGetListCatColonias()
        {
            var FicResult = from perdatadi in FicLoDBContext.cat_colonias select perdatadi;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetCatInstitutos")]
        public ContentResult FicGetListCatInstitutos()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };

            var FicResult = from cli in FicLoDBContext.cat_institutos select cli;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatTipoGrupos")]
        public ContentResult FicGetListRhCatTipoGrupos()
        {
            var FicResult = from insper in FicLoDBContext.rh_cat_tipo_grupos select insper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatGrupos")]
        public ContentResult FicGetListRhCatGrupos()
        {
            var FicResult = from insper in FicLoDBContext.rh_cat_grupos select insper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatPerfiles")]
        public ContentResult FicGetListRhCatPerfiles()
        {
            var FicResult = from insper in FicLoDBContext.rh_cat_perfiles select insper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }



        //---------------------------GET DATA CRUD--------------------------------//


        [HttpGet("GetRhCatPersonas")]
        public ContentResult FicGetListRhCatPersonas()
        {
            var FicResult = from per in FicLoDBContext.rh_cat_personas select per;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatDomicilios")]
        public ContentResult FicGetListRhCatDomicilios()
        {
            var FicResult = from dom in FicLoDBContext.rh_cat_domicilios select dom;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatTelefonos")]
        public ContentResult FicGetListRhCatTelefonos()
        {
            var FicResult = from tel in FicLoDBContext.rh_cat_telefonos select tel;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatPersonasPerfiles")]
        public ContentResult FicGetListRhCatPersonasPerfiles()
        {
            var FicResult = from perper in FicLoDBContext.rh_cat_personas_perfiles select perper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatAlumnos")]
        public ContentResult FicGetListRhCatAlumnos()
        {
            var FicResult = from alu in FicLoDBContext.rh_cat_alumnos select alu;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatEmpleados")]
        public ContentResult FicGetListRhCatEmpleados()
        {
            var FicResult = from emp in FicLoDBContext.rh_cat_empleados select emp;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatCatedraticos")]
        public ContentResult FicGetListRhCatCatedraticos()
        {
            var FicResult = from cat in FicLoDBContext.rh_cat_catedraticos select cat;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatdDirWeb")]
        public ContentResult FicGetListRhCatdDirWeb()
        {
            var FicResult = from dirw in FicLoDBContext.rh_cat_dir_web select dirw;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhPersonasPerfilEstatus")]
        public ContentResult FicGetListRhPersonasPerfilEstatus()
        {
            var FicResult = from perperest in FicLoDBContext.rh_personas_perfil_estatus select perperest;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatPersonasDatosAdicionales")]
        public ContentResult FicGetListRhCatPersonasDatosAdicionales()
        {
            var FicResult = from perdatadi in FicLoDBContext.rh_cat_personas_datos_adicionales select perdatadi;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetBecCatClientes")]
        public ContentResult FicGetListBecCatClientes()
        {
            var FicResult = from cli in FicLoDBContext.bec_cat_clientes select cli;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetBecInstitutosPersonas")]
        public ContentResult FicGetListBecInstitutosPersonas()
        {
            var FicResult = from insper in FicLoDBContext.bec_institutos_personas select insper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }


        //----------------------------------GET BY ID PERSONA---------------------------------//
        [HttpGet("GetRhCatPersonas/{IdPersona}", Name = "GetPersonas")]
        public IActionResult FicGetListRhCatPersonasById(int IdPersona)
        {
            var FicResult = from per in FicLoDBContext.rh_cat_personas where per.IdPersona == IdPersona select per;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatDomicilios/{IdPersona}", Name = "GetDomicilios")]
        public IActionResult FicGetListRhCatDomiciliosById(int IdPersona)
        {
            var FicResult = from dom in FicLoDBContext.rh_cat_domicilios where int.Parse(dom.ClaveReferencia) == IdPersona select dom;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatTelefonos/{IdPersona}", Name = "GetTelefonos")]
        public IActionResult FicGetListRhCatTelefonosById(int IdPersona)
        {
            var FicResult = from tel in FicLoDBContext.rh_cat_telefonos where int.Parse(tel.ClaveReferencia) == IdPersona select tel;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatPersonasPerfiles/{IdPersona}", Name = "GetPefiles")]
        public IActionResult FicGetListRhCatPersonasPerfilesById(int IdPersona)
        {
            var FicResult = from perper in FicLoDBContext.rh_cat_personas_perfiles where perper.IdPersona == IdPersona select perper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatAlumnos/{IdPersona}", Name = "GetAlumnos")]
        public IActionResult FicGetListRhCatAlumnosById(int IdPersona)
        {
            var FicResult = from alu in FicLoDBContext.rh_cat_alumnos where alu.IdAlumno == IdPersona select alu;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatEmpleados/{IdPersona}", Name = "GetEmpleados")]
        public IActionResult FicGetListRhCatEmpleadosById(int IdPersona)
        {
            var FicResult = from emp in FicLoDBContext.rh_cat_empleados where emp.IdEmpleado == IdPersona select emp;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatCatedraticos/{IdPersona}", Name = "GetCatedraticos")]
        public IActionResult FicGetListRhCatCatedraticosById(int IdPersona)
        {
            var FicResult = from cat in FicLoDBContext.rh_cat_catedraticos where cat.IdEmpleado == IdPersona select cat;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatdDirWeb/{IdPersona}", Name = "GetDireccionesWeb")]
        public IActionResult FicGetListRhCatdDirWebById(int IdPersona)
        {
            var FicResult = from dirw in FicLoDBContext.rh_cat_dir_web where int.Parse(dirw.ClaveReferencia) == IdPersona select dirw;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhPersonasPerfilEstatus/{IdPersona}", Name = "GetPerfilesEstatus")]
        public IActionResult FicGetListRhPersonasPerfilEstatusById(int IdPersona)
        {
            var FicResult = from perperest in FicLoDBContext.rh_personas_perfil_estatus where perperest.IdPersona == IdPersona select perperest;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetRhCatPersonasDatosAdicionales/{IdPersona}", Name = "GetDatosAdicionales")]
        public IActionResult FicGetListRhCatPersonasDatosAdicionalesById(int IdPersona)
        {
            var FicResult = from perdatadi in FicLoDBContext.rh_cat_personas_datos_adicionales where perdatadi.IdPersona == IdPersona select perdatadi;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetBecCatClientes/{IdPersona}", Name = "GetClientes")]
        public IActionResult FicGetListBecCatClientesById(int IdPersona)
        {
            var FicResult = from cli in FicLoDBContext.bec_cat_clientes where cli.IdCliente == IdPersona select cli;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }

        [HttpGet("GetBecInstitutosPersonas/{IdPersona}", Name = "GetInstitutosPersonas")]
        public IActionResult FicGetListBecInstitutosPersonasById(int IdPersona)
        {
            var FicResult = from insper in FicLoDBContext.bec_institutos_personas where insper.IdPersona == IdPersona select insper;
            String FicSererializa = JsonConvert.SerializeObject(FicResult);
            return Content(FicSererializa, "application/json");
        }


        //-----------------------------------POST AND PUT-------------------------------------//


        [HttpPost("AddPerson")]
        public async Task<IActionResult> FicApiPostPersonas([FromBody] reg_personas personas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                foreach (rh_cat_personas per in personas.rh_cat_personas)
                {
                    var per_exist = FicLoDBContext.rh_cat_personas.FirstOrDefault(X => X.IdPersona == per.IdPersona);
                    if (per_exist == null)
                    {

                        FicLoDBContext.rh_cat_personas.Add(per);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        per_exist.Sexo = per.Sexo;
                        per_exist.Activo = per.Activo;
                        per_exist.Alias = per.Alias;
                        per_exist.ApMaterno = per.ApMaterno;
                        per_exist.ApPaterno = per.ApPaterno;
                        per_exist.Borrado = per.Borrado;
                        per_exist.CURP = per.CURP;
                        per_exist.FechaNac = per.FechaNac;
                        per_exist.FechaReg = per.FechaReg;
                        per_exist.FechaUltMod = per.FechaUltMod;
                        per_exist.IdGenEstadoCivil = per.IdGenEstadoCivil;
                        per_exist.IdGenOcupacion = per.IdGenOcupacion;
                        per_exist.IdInstituto = per.IdInstituto;
                        per_exist.RFC = per.RFC;
                        //IdPersona = per.IdPersona;
                        per_exist.IdTipoGenEstadoCivil = per.IdTipoGenEstadoCivil;
                        per_exist.IdTipoGenOcupacion = per.IdTipoGenOcupacion;
                        per_exist.Nombre = per.Nombre;
                        per_exist.NumControl = per.NumControl;
                        per_exist.RutaFoto = per.RutaFoto;
                        per_exist.TipoPersona = per.TipoPersona;
                        per_exist.UsuarioMod = per.UsuarioMod;
                        per_exist.UsuarioReg = per.UsuarioReg;

                        FicLoDBContext.Entry(per_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }


                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_telefonos tel in personas.rh_cat_telefonos)
                {
                    var tel_exist = FicLoDBContext.rh_cat_telefonos.FirstOrDefault(X => X.IdTelefono == tel.IdTelefono);
                    if (tel_exist == null)
                    {

                        FicLoDBContext.rh_cat_telefonos.Add(tel);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        tel_exist.CodPais = tel.CodPais;
                        tel_exist.NumTelefono = tel.NumTelefono;
                        tel_exist.NumExtension = tel.NumExtension;
                        tel_exist.Principal = tel.Principal;
                        tel_exist.IdTipoGenTelefono = tel.IdTipoGenTelefono;
                        tel_exist.IdGenTelefono = tel.IdGenTelefono;
                        tel_exist.ClaveReferencia = tel.ClaveReferencia;
                        tel_exist.Referencia = tel.Referencia;
                        tel_exist.FechaReg = tel.FechaReg;
                        tel_exist.FechaUltMod = tel.FechaUltMod;
                        tel_exist.UsuarioReg = tel.UsuarioReg;
                        tel_exist.UsuarioMod = tel.UsuarioMod;
                        tel_exist.Activo = tel.Activo;
                        tel_exist.Borrado = tel.Borrado;

                        FicLoDBContext.Entry(tel_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_domicilios dom in personas.rh_cat_domicilios)
                {
                    var dom_exist = FicLoDBContext.rh_cat_domicilios.FirstOrDefault(X => X.IdDomicilio == dom.IdDomicilio);
                    if (dom_exist == null)
                    {

                        FicLoDBContext.rh_cat_domicilios.Add(dom);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        dom_exist.Domicilio = dom.Domicilio;
                        dom_exist.EntreCalle1 = dom.EntreCalle1;
                        dom_exist.EntreCalle2 = dom.EntreCalle2;
                        dom_exist.CodigoPostal = dom.CodigoPostal;
                        dom_exist.Coordenadas = dom.Coordenadas;
                        dom_exist.Principal = dom.Principal;
                        dom_exist.IdTipoGenDom = dom.IdTipoGenDom;
                        dom_exist.IdGenDom = dom.IdGenDom;
                        dom_exist.Pais = dom.Pais;
                        dom_exist.Estado = dom.Estado;
                        dom_exist.Municipio = dom.Municipio;
                        dom_exist.Localidad = dom.Localidad;
                        dom_exist.Colonia = dom.Colonia;
                        dom_exist.TipoDomicilio = dom.TipoDomicilio;
                        dom_exist.ClaveReferencia = dom.ClaveReferencia;
                        dom_exist.Referencia = dom.Referencia;
                        dom_exist.FechaReg = dom.FechaReg;
                        dom_exist.FechaUltMod = dom.FechaUltMod;
                        dom_exist.UsuarioReg = dom.UsuarioReg;
                        dom_exist.UsuarioMod = dom.UsuarioMod;
                        dom_exist.Activo = dom.Activo;
                        dom_exist.Borrado = dom.Borrado;

                        FicLoDBContext.Entry(dom_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_personas_perfiles perper in personas.rh_cat_personas_perfiles)
                {
                    var perper_exist = FicLoDBContext.rh_cat_personas_perfiles.FirstOrDefault(
                        X => X.IdPersona == perper.IdPersona &&
                        X.IdPerfil == perper.IdPerfil);
                    if (perper_exist == null)
                    {

                        FicLoDBContext.rh_cat_personas_perfiles.Add(perper);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        perper_exist.Activo = perper.Activo;
                        perper_exist.FechaReg = perper.FechaReg;
                        perper_exist.UsuarioReg = perper.UsuarioReg;
                        perper_exist.FechaUltMod = perper.FechaUltMod;
                        perper_exist.UsuarioMod = perper.UsuarioMod;
                        perper_exist.Borrado = perper.Borrado;

                        FicLoDBContext.Entry(perper_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_alumnos alu in personas.rh_cat_alumnos)
                {
                    var alu_exist = FicLoDBContext.rh_cat_alumnos.FirstOrDefault(X => X.IdAlumno == alu.IdAlumno);
                    if (alu_exist == null)
                    {

                        FicLoDBContext.rh_cat_alumnos.Add(alu);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        alu_exist.NumControl = alu.NumControl;
                        alu_exist.FechaReg = alu.FechaReg;
                        alu_exist.FechaUltMod = alu.FechaUltMod;
                        alu_exist.UsuarioReg = alu.UsuarioReg;
                        alu_exist.UsuarioMod = alu.UsuarioMod;
                        alu_exist.Activo = alu.Activo;
                        alu_exist.Borrado = alu.Borrado;
                        alu_exist.IdCarrera = alu.IdCarrera;

                        FicLoDBContext.Entry(alu_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_empleados emp in personas.rh_cat_empleados)
                {
                    var emp_exist = FicLoDBContext.rh_cat_empleados.FirstOrDefault(X => X.IdEmpleado == emp.IdEmpleado);
                    if (emp_exist == null)
                    {
                        FicLoDBContext.rh_cat_empleados.Add(emp);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        emp_exist.NumControl = emp.NumControl;
                        emp_exist.FechaReg = emp.FechaReg;
                        emp_exist.FechaUltMod = emp.FechaUltMod;
                        emp_exist.UsuarioReg = emp.UsuarioReg;
                        emp_exist.UsuarioMod = emp.UsuarioMod;
                        emp_exist.Borrado = emp.Borrado;

                        FicLoDBContext.Entry(emp_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_catedraticos cat in personas.rh_cat_catedraticos)
                {
                    var cat_exist = FicLoDBContext.rh_cat_catedraticos.FirstOrDefault(X => X.IdEmpleado == cat.IdEmpleado);
                    if (cat_exist == null)
                    {
                        FicLoDBContext.rh_cat_catedraticos.Add(cat);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        cat_exist.FechaReg = cat.FechaReg;
                        cat_exist.FechaUltMod = cat.FechaUltMod;
                        cat_exist.UsuarioReg = cat.UsuarioReg;
                        cat_exist.UsuarioMod = cat.UsuarioMod;
                        cat_exist.Activo = cat.Activo;
                        cat_exist.Borrado = cat.Borrado;

                        FicLoDBContext.Entry(cat_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_dir_web dirw in personas.rh_cat_dir_web)
                {
                    var dirw_exist = FicLoDBContext.rh_cat_dir_web.FirstOrDefault(X => X.IdDirWeb == dirw.IdDirWeb);
                    if (dirw_exist == null)
                    {

                        FicLoDBContext.rh_cat_dir_web.Add(dirw);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        dirw_exist.DesDirWeb = dirw.DesDirWeb;
                        dirw_exist.DireccionWeb = dirw.DireccionWeb;
                        dirw_exist.Principal = dirw.Principal;
                        dirw_exist.IdTipoGenDirWeb = dirw.IdTipoGenDirWeb;
                        dirw_exist.IdGenDirWeb = dirw.IdGenDirWeb;
                        dirw_exist.ClaveReferencia = dirw.ClaveReferencia;
                        dirw_exist.Referencia = dirw.Referencia;
                        dirw_exist.FechaReg = dirw.FechaReg;
                        dirw_exist.FechaUltMod = dirw.FechaUltMod;
                        dirw_exist.Activo = dirw.Activo;
                        dirw_exist.Borrado = dirw.Borrado;
                        dirw_exist.UsuarioReg = dirw.UsuarioReg;
                        dirw_exist.UsuarioMod = dirw.UsuarioMod;

                        FicLoDBContext.Entry(dirw_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_personas_perfil_estatus perperest in personas.rh_personas_perfil_estatus)
                {
                    var perperest_exist = FicLoDBContext.rh_personas_perfil_estatus.FirstOrDefault(X =>
                    X.IdPersona == perperest.IdPersona &&
                    X.IdEstatusDet == perperest.IdEstatusDet &&
                    X.IdPerfil == perperest.IdPerfil);
                    if (perperest_exist == null)
                    {
                        FicLoDBContext.rh_personas_perfil_estatus.Add(perperest);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        perperest_exist.FechaEstatus = perperest.FechaEstatus;
                        perperest_exist.IdTipoEstatus = perperest.IdTipoEstatus;
                        perperest_exist.IdEstatus = perperest.IdEstatus;
                        perperest_exist.Actual = perperest.Actual;
                        perperest_exist.Observacion = perperest.Observacion;
                        perperest_exist.FechaReg = perperest.FechaReg;
                        perperest_exist.FechaUltMod = perperest.FechaUltMod;
                        perperest_exist.UsuarioReg = perperest.UsuarioReg;
                        perperest_exist.UsuarioMod = perperest.UsuarioMod;
                        perperest_exist.Activo = perperest.Activo;
                        perperest_exist.Borrado = perperest.Borrado;

                        FicLoDBContext.Entry(perperest_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (rh_cat_personas_datos_adicionales perdatadi in personas.rh_cat_personas_datos_adicionales)
                {
                    var perdatadi_exist = FicLoDBContext.rh_cat_personas_datos_adicionales.FirstOrDefault(X =>
                    X.IdPersona == perdatadi.IdPersona &&
                    X.IdDatoAdicional == perdatadi.IdDatoAdicional);
                    if (perdatadi_exist == null)
                    {

                        FicLoDBContext.rh_cat_personas_datos_adicionales.Add(perdatadi);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        //eva_cat_perficios uperf = new eva_cat_perficios();

                        perdatadi_exist.Etiqueta = perdatadi.Etiqueta;
                        perdatadi_exist.Valor = perdatadi.Valor;
                        perdatadi_exist.IdTipoGenSeccion = perdatadi.IdTipoGenSeccion;
                        perdatadi_exist.IdGenSeccion = perdatadi.IdGenSeccion;
                        perdatadi_exist.FechaReg = perdatadi.FechaReg;
                        perdatadi_exist.FechaUltMod = perdatadi.FechaUltMod;
                        perdatadi_exist.UsuarioReg = perdatadi.UsuarioReg;
                        perdatadi_exist.UsuarioMod = perdatadi.UsuarioMod;
                        perdatadi_exist.Activo = perdatadi.Activo;
                        perdatadi_exist.Borrado = perdatadi.Borrado;

                        FicLoDBContext.Entry(perdatadi_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (bec_cat_clientes cli in personas.bec_cat_clientes)
                {
                    var cli_exist = FicLoDBContext.bec_cat_clientes.FirstOrDefault(X =>
                    X.IdCliente == cli.IdCliente);
                    if (cli_exist == null)
                    {
                        FicLoDBContext.bec_cat_clientes.Add(cli);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        cli_exist.FechaAlta = cli.FechaAlta;
                        cli_exist.FechaReg = cli.FechaReg;
                        cli_exist.IdTipoGrupo = cli.IdTipoGrupo;
                        cli_exist.IdGrupo = cli.IdGrupo;
                        cli_exist.FechaUltMod = cli.FechaUltMod;
                        cli_exist.Activo = cli.Activo;
                        cli_exist.Borrado = cli.Borrado;
                        cli_exist.UsuarioReg = cli.UsuarioReg;
                        cli_exist.UsuarioMod = cli.UsuarioMod;

                        FicLoDBContext.Entry(cli_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                    //return CreatedAtAction("", per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            try
            {
                foreach (bec_institutos_personas insper in personas.bec_institutos_personas)
                {
                    var insper_exist = FicLoDBContext.bec_institutos_personas.FirstOrDefault(X =>
                    X.IdPersona == insper.IdPersona);
                    if (insper_exist == null)
                    {
                        FicLoDBContext.bec_institutos_personas.Add(insper);
                        FicLoDBContext.SaveChanges();
                    }
                    else
                    {
                        insper_exist.Activo = insper.Activo;
                        insper_exist.FechaReg = insper.FechaReg;
                        insper_exist.UsuarioReg = insper.UsuarioReg;
                        insper_exist.FechaUltMod = insper.FechaUltMod;
                        insper_exist.UsuarioMod = insper.UsuarioMod;
                        insper_exist.Borrado = insper.Borrado;

                        FicLoDBContext.Entry(insper_exist).State = EntityState.Modified;
                        FicLoDBContext.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            String FicSererializa = JsonConvert.SerializeObject(personas);
            return Content(FicSererializa, "application/json");
           //return CreatedAtAction("", personas);

        }


        //[HttpPost("AddDomicilios")]
        //public async Task<IActionResult> FicApiPostDomiciolios([FromBody] reg_personas domicilios)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", domicilios);

        //}


        //[HttpPost("AddTelefonos")]
        //public async Task<IActionResult> FicApiPostTelefonos([FromBody] List<rh_cat_telefonos> telefonos)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", telefonos);

        //}


        //[HttpPost("AddPersonasPerfiles")]
        //public async Task<IActionResult> FicApiPostPersonasPerfiles([FromBody] List<rh_cat_personas_perfiles> personas_perfiles)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", personas_perfiles);

        //}


        //[HttpPost("AddAlumnos")]
        //public async Task<IActionResult> FicApiPostAlumnos([FromBody] List<rh_cat_alumnos> alumnos)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", alumnos);

        //}


        //[HttpPost("AddEmpleados")]
        //public async Task<IActionResult> FicApiPostEmpleados([FromBody] List<rh_cat_empleados> empleados)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", empleados);

        //}


        //[HttpPost("AddCatedraticos")]
        //public async Task<IActionResult> FicApiPostCatedraticos([FromBody] List<rh_cat_catedraticos> catedraticos)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", catedraticos);

        //}


        //[HttpPost("AddDirWeb")]
        //public async Task<IActionResult> FicApiPostDirWeb([FromBody] List<rh_cat_dir_web> dirsweb)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", dirsweb);

        //}


        //[HttpPost("AddPersonasPerfilEstatus")]
        //public async Task<IActionResult> FicApiPostPersonasPerfilEstatus([FromBody] List<rh_personas_perfil_estatus> personas_perfiles_estatus)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", personas_perfiles_estatus);

        //}


        //[HttpPost("AddPersonasDatosAdicionales")]
        //public async Task<IActionResult> FicApiPostPersonasDatosAdicionales([FromBody] List<rh_cat_personas_datos_adicionales> personas_datos_adicionales)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", personas_datos_adicionales);

        //}


        //[HttpPost("Addclientes")]
        //public async Task<IActionResult> FicApiPostClientes([FromBody] List<bec_cat_clientes> clientes)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", clientes);

        //}


        //[HttpPost("AddInstitutosPersonas")]
        //public async Task<IActionResult> FicApiPostInstitutosPersonas([FromBody] List<bec_institutos_personas> institutos_personas)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return CreatedAtAction("", institutos_personas);

        //}
    }
}