using System.ComponentModel.DataAnnotations;

namespace ProjAPI.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string bairro, string cidade, string pais, string cEP, string logradouro, string estado, int numero, string complemento)
        {
            Id = id;
            Bairro = bairro;
            Cidade = cidade;
            Pais = pais;
            CEP = cEP;
            Logradouro = logradouro;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
        }
    }
}
