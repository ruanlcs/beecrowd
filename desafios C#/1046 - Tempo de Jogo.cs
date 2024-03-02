//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(valor[0]);
        int B = Convert.ToInt32(valor[1]);
        int C = 0;
        
        if(A<B){
            C = B - A;
            Console.WriteLine("O JOGO DUROU " + C + " HORA(S)");
            
        }else if(A>B){
            C = 24 - (A-B);
            Console.WriteLine("O JOGO DUROU " + C + " HORA(S)");
        }else if(A==B) {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }

    }

}
