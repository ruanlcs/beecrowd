//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

    String line = Console.ReadLine();
    string[] valor = line.Split(' ');
    double A = Convert.ToDouble(valor[0]);
    double B = Convert.ToDouble(valor[1]);
    double C = Convert.ToDouble(valor[2]);
    
    double delta = Math.Pow(B,2) - 4*A*C;

    if(A==0 || delta<0 ){
        Console.WriteLine("Impossivel calcular");

    } else {
  
        double r1 = (-B + Math.Sqrt(delta))/(2.0*A);
        double r2 = (-B - Math.Sqrt(delta))/(2.0*A);
        Console.WriteLine("R1 = " +r1.ToString("F5"));
        Console.WriteLine("R2 = " +r2.ToString("F5"));
     }

  }

}
