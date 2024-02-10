//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

       int numeroDoFuncionario = Int32.Parse(Console.ReadLine());
       int horasTrabalhadas = Int32.Parse(Console.ReadLine());
       double valorDaHora = Double.Parse(Console.ReadLine());
      
       double salario = horasTrabalhadas*valorDaHora;
       Console.WriteLine("NUMBER = " + numeroDoFuncionario);
       Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));

    }

}
