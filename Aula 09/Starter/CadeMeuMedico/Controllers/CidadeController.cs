using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeMeuMedico.Dto;
using CadeMeuMedico.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Index()
        {
            var client = new CidadeClient();
            var cidades = client.ObterTodas();
            ViewBag.cidades = cidades;
            return View();
        }



        // GET: Cidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CidadeDto cidade)
        {
            try
            {
                var cliente = new CidadeClient();
                cliente.Criar(cidade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Cidade/Details/5
        public ActionResult Details(int id)
        {
            var cidadeCliente = new CidadeClient();
            var cidade = cidadeCliente.ObterPorId(id);

            return View(cidade);
        }




        [Authorize]
        [HttpGet]
        public string MeuMetodo(string nomeCidade)
        {
            return "Bem vindo a " + nomeCidade;
        }


        // GET: Cidade/Edit/5
        public ActionResult Edit(int id)
        {
            var cidadeCliente = new CidadeClient();
            var cidade = cidadeCliente.ObterPorId(id);

            return View(cidade);
        }

        // POST: Cidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CidadeDto cidade)
        {
            try
            {
                var cidadeCliente = new CidadeClient();
                cidadeCliente.Atualizar(cidade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cidade/Delete/5
        public ActionResult Delete(int id)
        {
            var cidadeCliente = new CidadeClient();
            var cidade = cidadeCliente.ObterPorId(id);

            return View(cidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CidadeDto cidade)
        {
            try
            {
                var cidadeCliente = new CidadeClient();
                cidadeCliente.Apagar(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}