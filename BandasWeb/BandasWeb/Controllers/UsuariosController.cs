using BandasWeb.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BandasWeb.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Buscar_salas()
        {
            int index = 0;
            Tabla_de_salas model = new Tabla_de_salas();
             Database1Entities de = new Database1Entities();
            foreach ( Sala sala in de.Sala) {
                SalasloadModel salas = new SalasloadModel();
                salas.Nombre_sala = sala.Nombre;
                model.lista_salas.Insert(index, salas);
            }

            return View(model);
        }

        // GET: Usuarios/Details/5
        public ActionResult Agregar_sala()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Agregar_salas(SalasSaveModel model)
        {
            using (Database1Entities de = new Database1Entities())
            {
                using (var dbContextTransaction = de.Database.BeginTransaction())
                {
                    try
                    {
                        Sala aux = new Sala();
                        foreach (Usuarios dueno in de.Usuarios)
                        {
                            if (dueno.Nombre_usuario.Equals(User.Identity.GetUserName()))
                            {
                                aux.Id_dueno = dueno.Id;

                            }
                        }
                        aux.Nombre = model.Nombre_sala;
                        de.Sala.Add(aux);
                        de.SaveChanges();
                        int aux2 = de.Sala.Max(u => u.Id);
                        Detalle_sala detalle = new Detalle_sala();
                        detalle.Ancho = model.ancho;
                        detalle.Id_Sala = aux2;
                        detalle.Largo = model.largo;
                        detalle.Max_musicos = model.max_musicos;
                        Horario_sala horario = new Horario_sala();
                        if (model.de8a10)
                        {
                            horario.Id_horario = 1;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de10a12)
                        {
                            horario.Id_horario = 2;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de12a14)
                        {
                            horario.Id_horario = 3;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de14a16)
                        {
                            horario.Id_horario = 4;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de16a18)
                        {
                            horario.Id_horario = 5;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de18a20)
                        {
                            horario.Id_horario = 6;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de20a22)
                        {
                            horario.Id_horario = 7;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        if (model.de22a24)
                        {
                            horario.Id_horario = 9;
                            horario.Id_sala = aux2;
                            de.Horario_sala.Add(horario);
                            de.SaveChanges();
                        }
                        Carac_sala caracteristicas = new Carac_sala();
                        if (model.carac_guitarra_ampli_50w)
                        {
                            caracteristicas.Id_Caracteristicas = 1;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        else if (model.carac_guitarra_ampli_100w)
                        {
                            caracteristicas.Id_Caracteristicas = 2;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        if (model.carac_bajo_ampli_100w)
                        {
                            caracteristicas.Id_Caracteristicas = 3;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        else if (model.carac_bajo_ampli_200w)
                        {
                            caracteristicas.Id_Caracteristicas = 4;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        if (model.carac_bateria_4cuerpos)
                        {
                            caracteristicas.Id_Caracteristicas = 5;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        else if (model.carac_bateria_5cuerpos)
                        {
                            caracteristicas.Id_Caracteristicas = 6;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        else if (model.carac_bateria_6cuerpos)
                        {
                            caracteristicas.Id_Caracteristicas = 7;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        if (model.carac_parlantes)
                        {
                            caracteristicas.Id_Caracteristicas = 8;
                            caracteristicas.Id_Sala = aux2;
                            de.Carac_sala.Add(caracteristicas);
                            de.SaveChanges();
                        }
                        return RedirectToAction("Index");
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        ViewBag.Message = ex.Message;
                        return View(model);
                    }
                }

            }
        }
        
        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
