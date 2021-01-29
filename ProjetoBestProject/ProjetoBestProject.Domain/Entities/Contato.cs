using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjetoBestProject.Infra.Data.Entities
{
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Contato()
        {
                
        }

        public Contato(int idContato, string nome, string telefone, string celular)
        {
            IdContato = idContato;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
        }
    }
}
