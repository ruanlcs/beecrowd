//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        int A = Convert.ToInt32(valor[0]);
        int B = Convert.ToInt32(valor[1]);
        
        if(A>B){
            if(A%B==0){
            Console.WriteLine("Sao Multiplos");        
            } else {
                 Console.WriteLine("Nao sao Multiplos"); 
            }
        
        } else  
        {
            if(B%A==0){
                Console.WriteLine("Sao Multiplos");
            } else {
                 Console.WriteLine("Nao sao Multiplos");   
            }
            
        
        }

    }

}
