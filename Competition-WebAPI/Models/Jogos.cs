using System.Collections.Generic;

namespace Competition_WebAPI.Models
{
    public class Jogos
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public double nota { get; set; }
        public int ano { get; set; }
        public string urlImagem { get; set; }
        public IEnumerable<Jogos> Jogo { get; set; }
        public Jogos() { }

        public Jogos(string id, string titulo, double nota, int ano, string urlImagem)
        {
            this.id = id;
            this.titulo = titulo;
            this.nota = nota;
            this.ano = ano;
            this.urlImagem = urlImagem;


        }

    }
}