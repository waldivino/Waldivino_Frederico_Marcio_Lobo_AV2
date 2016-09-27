using Application.Interface;
using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProcessosController : Controller
    {

        private readonly IProcessoAppService _processoApp;

        public ProcessosController(IProcessoAppService processoApp)
        {
            _processoApp = processoApp;
        }

        // GET: Processos
        public ActionResult Index()
        {
            var processoViewModel = Mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(_processoApp.GetAll());
            return View(processoViewModel);
        }

        // GET: Processos/Details/5
        public ActionResult Details(int id)
        {
            var processo = _processoApp.GetById(id);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // GET: Processos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Processos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProcessoViewModel processo)
        {
            var processoDomain = Mapper.Map<ProcessoViewModel, Processo>(processo);
            _processoApp.Add(processoDomain);

            return RedirectToAction("Index");
        }

        // GET: Processos/Edit/5
        public ActionResult Edit(int id)
        {
            var processo = _processoApp.GetById(id);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // POST: Processo/Edit/5
        [HttpPost]
        public ActionResult Edit(ProcessoViewModel processo)
        {
            if (ModelState.IsValid)
            {
                var processoDomain = Mapper.Map<ProcessoViewModel, Processo>(processo);
                _processoApp.Update(processoDomain);

                return RedirectToAction("Index");
            }

            return View(processo);
        }

        // GET: Processos/Delete/5
        public ActionResult Delete(int id)
        {
            var processo = _processoApp.GetById(id);
            var processoViewModel = Mapper.Map<Processo, ProcessoViewModel>(processo);
            return View(processoViewModel);
        }

        // POST: Processos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var processo = _processoApp.GetById(id);
            _processoApp.Remove(processo);
            return RedirectToAction("Index");
        }

    }
}
