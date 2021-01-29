using ProjetoBestProject.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBestProject.Presentation.Mvc.Model
{
    public class ContatoCadastroModel
    {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do contato.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Telefone de contato.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Celular de contato.")]
        public string Celular { get; set; }

        public List<Contato> Contatos { get; set; }
    }
}
