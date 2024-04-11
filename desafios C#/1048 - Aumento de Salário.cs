//author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        double salario = Convert.ToDouble(Console.ReadLine());
        double ajuste = 0;
        if(0 < salario && salario <= 400 ){
            ajuste = salario * 0.15;
            salario = salario + ajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: {0:N2}", ajuste);
            Console.WriteLine("Em percentual: 15 %");
        }else if( 400 < salario && salario<= 800){
            ajuste = salario * 0.12;
            salario = salario + ajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: {0:N2}", ajuste);
            Console.WriteLine("Em percentual: 12 %");
        }else if(800 < salario && salario <= 1200){
            ajuste = salario * 0.10;
            salario = salario + ajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: {0:N2}", ajuste);
            Console.WriteLine("Em percentual: 10 %");
        }else if(1200 < salario && salario <= 2000){
            ajuste = salario * 0.07;
            salario = salario + ajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: {0:N2}", ajuste);
            Console.WriteLine("Em percentual: 7 %");
        }else if(salario > 2000){
            ajuste = salario * 0.04;
            salario = salario + ajuste;
            Console.WriteLine("Novo salario: " + salario.ToString("F2"));
            Console.WriteLine("Reajuste ganho: {0:N2}", ajuste);
            Console.WriteLine("Em percentual: 4 %");
        }

    }

}
