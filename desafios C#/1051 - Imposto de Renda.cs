using System; 

class URI {

    static void Main(string[] args) { 

               double s = Convert.ToDouble(Console.ReadLine());
        double f1 = 0;
        double f2 = 0;
        double f3 = 0;
        double r = 0;
        
        if(0 < s && s <= 2000){
            Console.WriteLine("Isento");
        }else{
            if(2000 < s && s <= 3000){
            f1 = s - 2000;
            f1 = (f1 * 8) / 100;
            r = f1;
            Console.WriteLine("R$ "+ r.ToString("F2"));
        }
        else if(3000 < s && s<= 4500){
            f1 = s - 2000;
            f2 = f1 - 1000;
            f1 -= f2;
            f1 = ((f1 * 8) / 100);
            f2 = ((f2 * 18) / 100);
            r = f2 + f1;
            Console.WriteLine("R$ "+ r.ToString("F2"));
        }
        else if (s > 4500){
            f1 = s - 2000;
            f2 = f1 - 1000;
            f3 = f2 - 1500;
            f1 -= f2;
            f2 -= f3;
            f1 = ((f1 * 8) / 100);
            f2 = ((f2 * 18) / 100);
            f3 = ((f3 * 28) / 100);
            r = f3 + f2 + f1;
            Console.WriteLine("R$ " + r.ToString("F2"));
        }
            
        }

    }

}
