//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        double raio = Double.Parse(Console.ReadLine());
        const double PI = 3.14159;
        double area = PI * raio * raio;
        Console.WriteLine("A=" + area.ToString("F4"));

    }

}
