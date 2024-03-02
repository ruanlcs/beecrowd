//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(valor[0]);
        double B = Convert.ToDouble(valor[1]);
        double C = Convert.ToDouble(valor[2]);
        
        double a = 0;
        double b = 0;
        double c = 0;
        if(A<=B && B<=C){
            a = C;
            b = B;
            c = A;
        }else if(A<=C && C<=B){
            a = B;
            b = C;
            c = A;
        }else if(B<=A && A<=C){
            a = C;
            b = A;
            c = B;
        }else if(B<=C && C<=A){
            a = A;
            b = C;
            c = B;
        }else if(C<=A && A<=B){
            a = B;
            b = A;
            c = C;
        }else if(C<=B && B<=A){
            a = A;
            b = B;
            c = C;
        }
        if(a>=(b+c)){
            Console.WriteLine("NAO FORMA TRIANGULO");
        } else {
          if(Math.Pow(a,2)==(Math.Pow(b,2)+Math.Pow(c,2))){
            Console.WriteLine("TRIANGULO RETANGULO");
        } if(Math.Pow(a,2)>(Math.Pow(b,2)+Math.Pow(c,2))){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        } if(Math.Pow(a,2)<(Math.Pow(b,2)+Math.Pow(c,2))){
            Console.WriteLine("TRIANGULO ACUTANGULO");
        } if(a==b && a==c && b==c){
            Console.WriteLine("TRIANGULO EQUILATERO");
        } if((a==b && b!=c) || (a==c && c!=b) || (b==c && c!=a)){
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
        }

    }

}
