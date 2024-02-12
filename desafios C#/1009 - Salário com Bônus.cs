//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
        double salario = Double.Parse(Console.ReadLine());
        double totalVendas = Double.Parse(Console.ReadLine());
        double resultado = (totalVendas * 0.15) + salario;
        Console.WriteLine("TOTAL = R$ " + Math.Round(resultado, 2).ToString("F2"));

    }

}
