//Author: @ruanlcs
using System; 

class URI {

    static void Main(string[] args) { 

        double Raio = Convert.ToDouble(Console.ReadLine());
        double PI = 3.14159;
        double volume = (4/3.0) * PI * Raio*Raio*Raio;
        Console.WriteLine("VOLUME = "+ volume.ToString("F3"));

    }

}
