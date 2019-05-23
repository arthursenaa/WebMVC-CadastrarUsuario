using System;

namespace Ex2_WebMVC.Models {
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public UsuarioModel (string nome, string email, string senha, DateTime dataNascimento) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }//Contrutor sempre tem o mesmo tamanho da classe

        public UsuarioModel (int id,string nome, string email, string senha, DateTime dataNascimento) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
    }
}