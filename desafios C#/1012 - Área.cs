//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 
        String line = Console.ReadLine();
        
        string[] valores = line.Split(' ');
        double A = Convert.ToDouble(valores[0]);
        double B = Convert.ToDouble(valores[1]);
        double C = Convert.ToDouble(valores[2]);
        
        double pi = 3.14159;
        double aTriangulo = A*C*0.5;
        double aCirculo = pi*C*C;
        double aTrapezio = (A+B)*C*0.5;
        double aQuadrado = B*B;
        double aRetangulo = A*B;
        
        Console.WriteLine("TRIANGULO: " + aTriangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + aCirculo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + aTrapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + aQuadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + aRetangulo.ToString("F3"));

    }

}
