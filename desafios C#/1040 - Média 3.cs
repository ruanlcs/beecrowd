//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        double N1 = Convert.ToDouble(valor[0]);
        double N2 = Convert.ToDouble(valor[1]);
        double N3 = Convert.ToDouble(valor[2]);
        double N4 = Convert.ToDouble(valor[3]);
        
        double media = (2*N1 + 3*N2 + 4*N3 + 1*N4)/10.0;
        if(5 <= media && media <= 6.9){
            Console.WriteLine("Media: {0:N1}", Math.Round(media,1));
            Console.WriteLine("Aluno em exame.");
            double N5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0:N1}", N5);
            media = (media + N5)/2.0;
            if(media >= 5 ){
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: {0:N1}", Math.Round(media,1));
            }else {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: {0:N1}", Math.Round(media,1));
            }
        }
        
       else if(media > 7){
            Console.WriteLine("Media: {0:N1}", Math.Round(media,1));
            Console.WriteLine("Aluno aprovado.");
        }else {
            Console.WriteLine("Media: {0:N1}", Math.Round(media,1));
            Console.WriteLine("Aluno reprovado.");
        }

    }

}
