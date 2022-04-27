using System; 
class URI {
    static void Main(string[] args) { 

        int positivo=0;
        for(int i=0; i<6; i++) {
            double num = double.Parse(Console.ReadLine());
            if(num > 0) 
                positivo++;
        }

        Console.WriteLine(positivo+" valores positivos");

    }
}