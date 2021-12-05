using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //enum
            var person = (Persons)0;
            Persons person2 = Persons.Sonya;
            Persons person3 = (Persons)4;

            //interface
            Animal animal = new Animal();
            animal.Nome = "Alfredo";
            animal.NomeDono = "Leon";
            animal.Especie = "Lobo";

            //classe
            Person pessoa = new Person();
            pessoa.Name = "Lucas";
            pessoa.Age = 21;
            pessoa.State = "PE";

            var pessoa2 = new Person();
            pessoa2.Name = "Kane";
            pessoa2.Age = 54;
            pessoa2.State = null;

            //namespace
            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(person3); 
        }
    }
}
