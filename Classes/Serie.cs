using DIO.Series.Enum;
using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private String? Titulo { get; set; }
        private String? Descricao { get; set; }
        private int Ano { get; set; }
        public bool Excluido { get; set; }

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            
			return retorno;
		}
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.id;
        }
        public void Exclui()
        {
            this.Excluido = true;
        }
         
      
    }
}