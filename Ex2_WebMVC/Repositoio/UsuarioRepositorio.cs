using System;
using System.Collections.Generic;
using System.IO;
using Ex2_WebMVC.Models;

namespace Ex2_WebMVC.Repositoio {
    public class UsuarioRepositorio {
        public UsuarioModel CadastrarUsuario (UsuarioModel usuario) {
            if (File.Exists ("usuarios.csv")) {
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            sw.Close ();

            return usuario;
        }

        public List<UsuarioModel> Listar () {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel> ();
            string[] linhas = File.ReadAllLines ("usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //Sair Do Foreach
                    continue;
                }
                string[] linha = item.Split (";");

                usuario = new UsuarioModel (
                    id: int.Parse (linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataNascimento: DateTime.Parse (linha[4])
                );
                listaDeUsuarios.Add (usuario);
            }
            return listaDeUsuarios;
        }
        public UsuarioModel BuscarPorId (int id) {
            List<UsuarioModel> listaDeUsuarios = Listar ();

            foreach (var item in listaDeUsuarios) {
                if (id == item.Id) {
                    return item;
                }
            }
            return null;
        }
        public UsuarioModel EditarUsuario (UsuarioModel usuario) {
            string[] linhas = File.ReadAllLines ("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty(linhas[i])) {
                    continue;
                }
                string[] dadosDaLinha = linhas[i].Split(";");
                //Vamos Verificar Se o ID De Usuario é igual ao da Linha;
                if (usuario.Id.ToString () == dadosDaLinha[0]){
                    linhas[i] = $"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}";
                    break;
                }
            }//Fim do for
            File.WriteAllLines("usuarios.csv", linhas);
            return usuario;
        }
    }
}