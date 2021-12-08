// See https://aka.ms/new-console-template for more information
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program 
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();



            //Operacao op2 = Calculadora.Subtrair;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op.Invoke(10, 5);
            //op2(10, 1);

            //op += Calculadora.Subtrair;
            //op.Invoke(10, 10);



            //const double pi = 3.14;
            //Console.WriteLine(pi);



            //Data data = new Data();
            //data.SetMes(4);
            //data.ApresentarMes();
            //data.Mes = 12;
            ////Console.WriteLine(data.Mes);
            //data.ApresentarMes();



            //Log lg = Log.GetInstance();

            //lg.PropriedadeLog = "Teste Instancia";

            //Log lg2 = Log.GetInstance();
            //Console.WriteLine(lg2.PropriedadeLog);



            //Aluno p1 = new Aluno("Johnny", "Cage", "Teste");
            //p1.Apresentar();
        }
    }
}