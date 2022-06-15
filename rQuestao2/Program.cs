/*Leitura de dados do usuário para consulta*/
Console.WriteLine("Digite o numero para verificação: ");
int numEnt;
numEnt = int.Parse(Console.ReadLine());

int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci;
var sequenciaFibonacci = new List<ListaFibonacci>();

/*Definido a sequencia de Fibonacci*/
for (int i = 0; i < 8; i++)
   {
       fibonacci = numeroAnterior + numeroAtual;
       sequenciaFibonacci.Add(new ListaFibonacci(fibonacci));
       numeroAnterior = numeroAtual;
       numeroAtual = fibonacci;
   }
/*Resposta da consulta*/
   var exists = sequenciaFibonacci.Any(x => x.Valor == numEnt);
       if (exists == true)
           {
               Console.WriteLine($"O valor existe na sequencia de Fibonacci");
           }
       else
           {
               Console.WriteLine("O valor não existe na sequencia de Fibonacci");
           }

/*Class para listar o resultado da sequência*/
public class ListaFibonacci 
{
   public ListaFibonacci(int valor)
   {
       Valor = valor;
   }

   public int Valor { get; set; }
}
