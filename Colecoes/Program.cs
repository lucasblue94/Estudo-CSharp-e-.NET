using Colecoes.Helper;
using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();


            Console.WriteLine("Mínimo: "+minimo);
            Console.WriteLine("Máximo: "+maximo);
            Console.WriteLine("Médio: "+medio);
            Console.WriteLine("Soma: "+soma);
            Console.WriteLine("Original: "+string.Join(", ", arrayNumeros));
            Console.WriteLine("Distinto: "+string.Join(", ", arrayUnico));

            //var numerosParesQuery =
            //    from num in arrayNumeros
            //    where num % 2 == 0
            //    orderby num
            //    select num;

            //var numerosParesMetodos = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            //Console.WriteLine("Numeros pares query: "+string.Join(", ", numerosParesQuery));
            //Console.WriteLine("Numeros pares método: "+string.Join(", ", numerosParesMetodos));
            
            
            
            
            
            
            //Dictionary<string, string> estados = new Dictionary<string, string>();

            //estados.Add("PE", "Pernambuco");
            //estados.Add("SC", "Santa Catarina");
            //estados.Add("SP", "São Paulo");

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}


            //string valorProcurado = Console.ReadLine().ToUpper();

            //if (estados.TryGetValue(valorProcurado, out string valor))
            //{
            //    Console.WriteLine(valor);
            //}
            //else
            //{
            //    Console.WriteLine("Valor "+valorProcurado+" não existe");
            //}

            //Console.WriteLine($"Removendo o valor: {valorProcurado}");
            //estados.Remove(valorProcurado);

            //foreach (KeyValuePair<string, string> item in estados)
            //{
            //    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            //}

            //Console.WriteLine("Valor original:");
            //Console.WriteLine(estados[valorProcurado]);

            //estados[valorProcurado] = "São Carlos";
            //Console.WriteLine("Valor atualizado:");
            //Console.WriteLine(estados[valorProcurado]);





            //Stack<string> pilha = new Stack<string>();

            //pilha.Push("Spider-Man");
            //pilha.Push("Avengers");
            //pilha.Push("Guardians of The Galaxy");

            //while (pilha.Count > 0)
            //{
            //    Console.WriteLine("Próximo da pilha: "+pilha.Peek());
            //    Console.WriteLine($"{pilha.Pop()} saiu");
            //}
            //Console.WriteLine("Resta na pilha: "+pilha.Count);






            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Johnny");
            //fila.Enqueue("Cage");
            //fila.Enqueue("Blade");

            //while (fila.Count > 0)
            //{
            //    Console.WriteLine($"Vez de: {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} atendido");
            //}

            //Console.WriteLine("Pessoas na fila: "+fila.Count);








            //OperaoesList opList = new OperaoesList();
            //List<string> estados = new List<string>() {"PE", "PB", "SC" };
            //string[] estadosArray = new string[2] { "SP", "RS" };

            //Console.WriteLine("Quantidade de elementos na lista: "+estados.Count);

            //opList.ImprimirListaString(estados);
            //Console.WriteLine();

            ////Console.WriteLine("Removendo elemento");
            ////estados.Remove("PB");

            ////estados.AddRange(estadosArray);
            //estados.Insert(1, "RJ");

            //opList.ImprimirListaString(estados);






            //OperacoesArray op = new OperacoesArray();
            //int[] array = new int[5] { 50, 53, 8, 90, 4 };
            //int[] arrayCopia = new int[10];
            //string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 8;

            //Console.WriteLine($"Capacidade atual do array: {array.Length}");
            //op.RedimensionarArray(ref array, 15);
            //Console.WriteLine($"Nova capacidade: {array.Length}");


            //int indice = op.ObterIndice(array, valorProcurado);

            //if (indice > -1)
            //{
            //    Console.WriteLine("O indice do elemento "+valorProcurado+" é: "+indice);
            //}
            //else
            //{
            //    Console.WriteLine("Valor não existe no array");
            //}




            //int valorAchado = op.ObterValor(array, valorProcurado);

            //if (valorAchado==valorProcurado)
            //{
            //    Console.WriteLine("Encontrei o valor");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado");
            //}

            //bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
            //if (todosMaiorQue)
            //{
            //    Console.WriteLine("Tdos maiores que "+valorProcurado);
            //}
            //else
            //{
            //    Console.WriteLine("Existem valores menores que " + valorProcurado); ;
            //}



            //bool existe = op.Existe(array, valorProcurado);
            //if (existe)
            //{
            //    Console.WriteLine("Valor encontrado");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não encontrado");
            //}

            //Console.WriteLine("Array original");
            //op.ImprimirArray(array);

            //Console.WriteLine();

            ////op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);
            //Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);

            //op.Copiar(ref array, ref arrayCopia);
            //op.ImprimirArray(arrayCopia);



            //int[,] matriz = new int[4, 2]
            //{
            //    { 8, 16 },
            //    {10, 20 },
            //    {50, 100 },
            //    {90, 180 }
            //};

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int cont = 0; cont < matriz.GetLength(1); cont++)
            //    {
            //        Console.WriteLine(matriz[i, cont]);
            //    }
            //}




            //int[] arrayInt = new int[3];

            //arrayInt[0] = 2;
            //arrayInt[1] = 4;
            //arrayInt[2] = int.Parse("6");

            //Console.WriteLine("Percorrendo por for");
            //for (int i = 0; i < arrayInt.Length; i++) 
            //{
            //    Console.WriteLine(arrayInt[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Percorrendo por foreach");
            //foreach (int item in arrayInt)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}