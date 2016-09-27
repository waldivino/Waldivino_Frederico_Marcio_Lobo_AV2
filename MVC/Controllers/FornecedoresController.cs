﻿using Application.Interface;
using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class FornecedoresController : Controller
    {

        private readonly IFornecedorAppService _fornecedorApp;

        public FornecedoresController(IFornecedorAppService fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }

        // GET: Fornecedores
        public ActionResult Index()
        {
            var fornecedorViewModel = Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorApp.GetAll());
            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Details/5
        public ActionResult Details(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedorViewModel, EnderecoViewModel enderecoViewModel)
        {
            var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedorViewModel);

            var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(enderecoViewModel);

            fornecedorDomain.Enderecos.Add(enderecoDomain);

            _fornecedorApp.Add(fornecedorDomain);

            return RedirectToAction("Index");
        }

        // GET: Fornecedores/Edit/5
        public ActionResult Edit(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Edit/5
        [HttpPost]
        public ActionResult Edit(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
                _fornecedorApp.Update(fornecedorDomain);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public ActionResult Delete(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var fornecedor = _fornecedorApp.GetById(id);
            _fornecedorApp.Remove(fornecedor);
            return RedirectToAction("Index");
        }

    }
}