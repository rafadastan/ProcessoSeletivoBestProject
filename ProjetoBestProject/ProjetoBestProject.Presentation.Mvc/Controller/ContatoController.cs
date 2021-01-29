using Microsoft.AspNetCore.Mvc;
using ProjetoBestProject.Domain.Contracts.Services;
using ProjetoBestProject.Infra.Data.Entities;
using ProjetoBestProject.Infra.Data.Repositories;
using ProjetoBestProject.Presentation.Mvc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBestProject.Presentation.Mvc
{
    public class ContatoController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(ContatoCadastroModel model,
            [FromServices] IContatoDomainService contatoDomainService)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var contato = new Contato();
                    
                    contato.Nome = model.Nome;
                    contato.Telefone = model.Telefone;
                    contato.Celular = model.Celular;

                    contatoDomainService.Inserir(contato);

                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso.";

                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
                }
            }

            model.Contatos = contatoDomainService.Consultar();

            return View(model);
        }

        public IActionResult Exclusao(int id,
            [FromServices] IContatoDomainService contatoDomainService)
        {
            try
            {
                var contato = contatoDomainService.ObterPorId(id);

                if (contato != null)
                {
                    contatoDomainService.Excluir(contato);
                    TempData["MensagemSucesso"] = "Contato excluídocom sucesso.";
                }
                else
                {
                    TempData["MensagemErro"] = "Contato não encontrado.";
                }
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = "Erro: " + e.Message;
            }
            return RedirectToAction("Cadastro");
        }
    }
}
