using System;

namespace Revisao
{

    class Program
    {

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAlunos = 0;
            string opcao;
            do
            {
                opcao = ObterOpcaoUsuario();

                switch (opcao)
                {
                    case "1":
                        Aluno aluno = new Aluno();

                        while (double.TryParse(aluno.Nome, out double naoimporta) || string.IsNullOrEmpty(aluno.Nome))
                        {
                            Console.WriteLine("Informe o nome do aluno:");
                            aluno.Nome = Console.ReadLine().ToUpper();
                            if (double.TryParse(aluno.Nome, out double naoimporta2))
                            {
                                Console.WriteLine();
                                Console.WriteLine("Caracteres numéricos não são permitidos");
                           
                            }
                        }

                        Console.WriteLine();
                        int loop = 1;
                        while (loop == 1)
                        {
                            Console.WriteLine("Informe a nota do aluno:");
                            if (double.TryParse(Console.ReadLine(), out double nota))
                            {
                                aluno.Nota = nota;
                                loop--;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Apenas caracteres numéricos são permitidos");
                            }
                        }
                            alunos[indiceAlunos] = aluno;
                        indiceAlunos++;
                        
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"ALUNO: {a.Nome}  -  NOTA: {a.Nota}");
                            }
                        }
                        
                        break;
                    case "3":
                        double media, soma = 0;
                        int quantidadeAlunos = 0;
                        for(int i = 0; i < alunos.Length ; i++)
                        {
                            if (alunos[i].Nome != null)
                            {
                                quantidadeAlunos++;
                                soma = alunos[i].Nota + soma;
                            }
                        }
                        media = soma / quantidadeAlunos;
                        Conceito conceitoGeral;
                        if (media < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (media < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (media < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (media < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine("MÉDIA GERAL: "+media+" - CONCEITO: "+conceitoGeral);

                        break;
                    case "X":
                        Console.WriteLine();
                        Console.WriteLine("Programa finalizado");
                        Console.WriteLine();

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
            }

            while (opcao != "X");
            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos:");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");

            string opcaousuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaousuario;
        }
    }
}