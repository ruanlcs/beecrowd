//author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 


        string[] valor = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(valor[0]);
        int B = Convert.ToInt32(valor[1]);
        int C = Convert.ToInt32(valor[2]);
        int D = Convert.ToInt32(valor[3]);
        
 
        
        if(C<=A && D<=B){
          C += 24;  
        } else if(D <= B){
            D += 60;
            C--;
        }
          int s1 = A*3600 + B*60;
         int s2 = C*3600 + D*60;
         int total = s2 - s1;
         int h = total/3600;
         int min = (total - (h * 3600))/60;
      
        Console.WriteLine ($"O JOGO DUROU {h} HORA(S) E {min} MINUTO(S)");
        }
}
