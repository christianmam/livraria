using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria2
{
	public class Exemplar
	{
		//Definir os atributos - características
		public string Tombo {get; set;}
	

		public void ExibirDadosExemplar()
		{
			Console.WriteLine("Tombo: " + Tombo);
		}
	}
}