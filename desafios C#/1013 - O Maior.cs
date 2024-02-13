//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        String line = Console.ReadLine();
        
        string[] valores = line.Split(' ');
        int A = Convert.ToInt32(valores[0]);
        int B = Convert.ToInt32(valores[1]);
        int C = Convert.ToInt32(valores[2]);
        
        double maiorAB = (A+B+Math.Abs(A-B))*.5;
        double maiorABC = (maiorAB+C+Math.Abs(maiorAB-C))*.5;
        
        Console.WriteLine(maiorABC + " eh o maior");

    }

}
