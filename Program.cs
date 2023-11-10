using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{public class Item {
		private int valor;
		private string proprietario;
		private string modelo;
		public int peso { get; set;}
		public Item(string prorietario){
			prorietario = this.proprietario;
			peso = 20;
		}
		public void aumentar_peso(int valor) {
			peso = peso + valor;
		}

	}

	class Program
	{
		

		static void Main(string[] args)
		{
          Item item1 = new Item ("José");
			item1.modelo = lixeira;
		}
	}
}
