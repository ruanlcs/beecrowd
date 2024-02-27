//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        int x = Convert.ToInt32(valor[0]);
        int y = Convert.ToInt32(valor[1]);
        int z = Convert.ToInt32(valor[2]);
        
        if(x<y && y<z){
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }else if(x<z && z<y ){
            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);
        }else if(z<x && x<y){
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }else if(z<y && y<x){
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(x);
        }else if(y<x && x<z){
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine(z);
        }else if(y<z && z<x){
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(x);
        }
        
        Console.WriteLine("\n"+x);
        Console.WriteLine(y);
        Console.WriteLine(z);

    }

}
