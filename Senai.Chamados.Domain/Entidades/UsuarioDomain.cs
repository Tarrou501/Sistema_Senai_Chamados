﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.Chamados.Domain.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDomain : BaseDomain
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }


        public string Telefone { get; set; }

        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(8)]
        public string Senha { get; set; }

        [MaxLength(8)]
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
