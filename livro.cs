using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
	public class Livro
	{
		//Padrão: CamelCase - NotaFiscal - ContaCorrente - PessoaFisica
		//Descrever a classe
		//Atributos: modificadorAcesso  tipo    nomeAtributo;
		//				+ -> public     string   nome

		//Encapsulamento é realizado utilizando o modificador de acesso private
		private string _nome;
		public string Nome {  
			get
			{
				return _nome;
			}
			set
			{ 
				if (!value.Equals("")) {
					_nome = value;
				}	
			}
		}
		public string Resumo { get; set; }
		
		private double valor;
		public double Valor { get { return valor; } set { valor = value; } }

        private double titulo;
		public double Titulo { get { return valor; } set { valor = value; } }

		private int paginas;
		public int Paginas { get { return paginas; } set { paginas = value; } }
		
		public string Autor {get; set; }
		
		private string idioma;
		//Métodos de acesso
		//Get
		public string GetIdioma() { return idioma; }
		//Set
	

        public Editora EditoraLivro { get; set; }

        public Exemplar ExemplarLivro {get; set;}

        public void ExibirDados()
		{
			string titulo = "\nDETALHES DO LIVRO";
			Console.WriteLine(titulo);
			Console.WriteLine("Nome: " + Nome);
			Console.WriteLine("Resumo:" + Resumo);
			Console.WriteLine("Valor: " + Valor);
			Console.WriteLine("Páginas: " + Paginas);

			if (TemEditora())
			{
				EditoraLivro.ExibirDadosEditora();
                //Console.WriteLine("tem editora");
			};

            if (TemExemplar())
			{
				ExemplarLivro.ExibirDadosExemplar();
                //Console.WriteLine("tem exemplar");
			}
		}

	

		public bool TemEditora()
		{
			return EditoraLivro != null;
		}

        public bool TemExemplar()
		{
			return ExemplarLivro != null;
		}
	

    }
}