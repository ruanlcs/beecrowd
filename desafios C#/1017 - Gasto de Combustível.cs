//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        int tempo = Convert.ToInt32(Console.ReadLine());
        int velocidade = Convert.ToInt32(Console.ReadLine());
        const double consumo = 12.0;
        
        double totalLitros = (velocidade/consumo)*tempo;
        
        Console.WriteLine(totalLitros.ToString("F3"));

    }

}
