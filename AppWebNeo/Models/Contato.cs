﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebNeo.Models
{
    public class Contato
    {
        public Contato(string nome, string email, string telefone, string endereco, string cidade)
        {
            
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Cidade = cidade;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }
}
