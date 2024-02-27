//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(valor[0]);
        double B = Convert.ToDouble(valor[1]);
        double C = Convert.ToDouble(valor[2]);
        
        if(A<(B+C) && B<(A+C) && C<(A+B)){
            double perimetro = A+B+C;
            Console.WriteLine("Perimetro = {0:N1}",perimetro);
        }else{
            double area = (A+B)*C/2.0;
            Console.WriteLine("Area = {0:N1}",area);
        }

    }

}
