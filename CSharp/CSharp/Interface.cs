using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Nome(String nome);
        void Dono(String nomeDono);
        void Especie(String especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }


        void IAnimal.Nome(string name)
        {
            Nome = name;
        }

        void IAnimal.Dono(string nameOwner)
        {
            NomeDono = nameOwner;
        }

        void IAnimal.Especie(string species)
        {
            Especie = species;
        }
    }
}
