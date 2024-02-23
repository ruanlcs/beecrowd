//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

    double valor = Convert.ToDouble(Console.ReadLine());

	  int inteiro, aux, aux1;

	  inteiro = Convert.ToInt32(Math.Floor(valor));
	  valor = 100*valor;
	  aux1 = Convert.ToInt32(Math.Floor(valor));


	Console.WriteLine("NOTAS:");
	Console.WriteLine(inteiro/100 + " nota(s) de R$ 100.00");
	aux = inteiro%100;
	Console.WriteLine(aux/50 + " nota(s) de R$ 50.00");
	aux = aux%50;
	Console.WriteLine(aux/20 + " nota(s) de R$ 20.00");
	aux = aux%20;
	Console.WriteLine(aux/10 + " nota(s) de R$ 10.00");
	aux = aux%10;
	Console.WriteLine(aux/5 + " nota(s) de R$ 5.00");
	aux = aux%5;
	Console.WriteLine(aux/2 + " nota(s) de R$ 2.00");
	aux = aux%2;
	Console.WriteLine("MOEDAS:");
	Console.WriteLine(aux/1 + " moeda(s) de R$ 1.00");
	
	aux1 = aux1%100;
	Console.WriteLine(aux1/50 + " moeda(s) de R$ 0.50");
	aux1 = aux1%50;
	Console.WriteLine(aux1/25 + " moeda(s) de R$ 0.25");
	aux1 = aux1%25;
	Console.WriteLine(aux1/10 + " moeda(s) de R$ 0.10");
	aux1 = aux1%10;
	Console.WriteLine(aux1/5 + " moeda(s) de R$ 0.05");
	aux1 = aux1%5;
	Console.WriteLine(aux1/1 + " moeda(s) de R$ 0.01");

    }

}
