using System;

namespace ExemploPOO.Models
{
	public class Pessoa
	{
		public string Nome{get; set;}

        public int Idade { get; set; }

		public virtual void Apresentar()
        {
            if (Idade > 1)
                Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
            else
                Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} ano");

        }
    }
}
