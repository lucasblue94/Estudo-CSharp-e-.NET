using System;
using ExemploPOO.Models;
using ExemploPOO.Interface;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C://workspace";
            var caminhoPath = Path.Combine(caminho, "Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo Teste Stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo Teste 0.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo Teste 0 Backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Teste 2", "Arquivo Teste Stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<String> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPath);
            //helper.ApagarDiretorio(caminhoPath, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "I Want it that way");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            //ICalculadora calc = new Calculadora();
            //Console.WriteLine(calc.Somar(10, 20));

            //Computador comp = new Computador();
            //Console.WriteLine(comp.ToString());


            //Corrente c = new Corrente();
            //c.Creditar(100);

            //c.ExibirSaldo();


            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: "+calc.Somar(10, 10));
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10, 10));


            //Aluno p1 = new Aluno();
            //p1.Nota = 7;
            //p1.Nome = "Lucas";
            //p1.Idade = 21;
            //p1.Apresentar();

            //Professor p2 = new Professor();
            //p2.Salario = 2000;
            //p2.Nome = "Giovanna";
            //p2.Idade = 35;
            //p2.Apresentar();


            //Retangulo r = new Retangulo();
            //r.DefinirMedidas(30, 35);

            //Console.WriteLine("Area: "+r.ObterArea());


            //Pessoa p1 = new Pessoa();

            // p1.Nome = "Lucas";
            // p1.Idade = 21;

            // p1.Apresentar();
        }
    }
}
