using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Tdoctor.Entities;
using Tdoctor.Models;
using Tdoctor;

namespace Tdoctor.Controllers
{
    public class EspecialidadDocController : Controller
    {
         private readonly ILogger<EspecialidadDocController> _logger;
        private readonly AplicationDbContext _dbContext;
 

        public EspecialidadDocController(ILogger<EspecialidadDocController> logger, AplicationDbContext context)
        {
            this._logger = logger;
            this._dbContext = context;
        }
 public IActionResult EspecialidadList()
        {
             EspecialidadModel espe = new EspecialidadModel();
            espe.Id = new Guid();
            espe.Operacion = 62;
            espe.NombreEspe = "Odontología";
            espe.TiempoOpera = 23;
         


            //  this._dbContext.Doctors.Add(dr);
            //  this._dbContext.SaveChanges();
            List<EspecialidadModel> list = new List<EspecialidadModel>();
            list = _dbContext.Especialidades.Select(s => new EspecialidadModel()
            {
                Id = s.Id,
                Operacion = s.Operacion,
                NombreEspe = s.NombreEspe,
                TiempoOpera = s.TiempoOpera


            }).ToList();


            return View(list);
        }
         public IActionResult EspecialidadSave()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EspecialidadSave(EspecialidadModel model)
        {

            if (ModelState.IsValid)
            {
                Especialidad espeAdd = new Especialidad
                {
                    Id = Guid.NewGuid(),
                    Operacion = model.Operacion,
                NombreEspe = model.NombreEspe,
                TiempoOpera = model.TiempoOpera
                };

                _dbContext.Especialidades.Add(espeAdd);
                _dbContext.SaveChanges();

                return RedirectToAction("EspecialidadList");
            }
            return View(model);
        }

        public IActionResult EspecialidadDeleted(Guid id)
        {
            var espec = _dbContext.Especialidades.FirstOrDefault(p => p.Id == id);
            if (espec != null)
            {
                _dbContext.Especialidades.Remove(espec);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("EspecialidadList");


        }

        public IActionResult EspecialidadEdit(Guid id)
        {
            var espec = _dbContext.Especialidades.FirstOrDefault(p => p.Id == id);
            if (espec == null)
            {
                return RedirectToAction("EspecialidadList");
            }
            var model = new EspecialidadModel
            {
                Id = espec.Id,
                  Operacion = espec.Operacion,
                NombreEspe = espec.NombreEspe,
                TiempoOpera = espec.TiempoOpera
            };

            return View(model);
        }
[HttpPost]
        public IActionResult EspecialidadEdit(EspecialidadModel model)
        {
            if (ModelState.IsValid)
            {
                var espec = _dbContext.Especialidades.FirstOrDefault(p => p.Id == model.Id);
                if (espec != null)
                {
                
                     espec.Operacion = model.Operacion;
                espec.NombreEspe = model.NombreEspe;
                espec.TiempoOpera = model.TiempoOpera;
                    _dbContext.SaveChanges();
                    return RedirectToAction("EspecialidadList");
                }
            }
            return View(model);
        }

    }






    }
