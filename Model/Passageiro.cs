using System;
using System.ComponentModel.DataAnnotations;

namespace ProjAPI.Model
{
    public class Passageiro
    {
        #region Propriedades
        [Key]
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public Passageiro()
        {
        }

        public Passageiro(string cPF, string nome, string telefone, DateTime dataNascimento, string email, Endereco endereco)
        {
            CPF = cPF;
            Nome = nome;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Email = email;
            Endereco = endereco;
        }
        #endregion
    }
}
