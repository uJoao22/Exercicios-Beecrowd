using System; 
class URI {
    static void Main(string[] args) { 

        int positivo=0;
        double soma=0;
        for(int i=0; i<6; i++) {
            double num = double.Parse(Console.ReadLine());
            if(num > 0) {
                positivo++;
                soma+=num;
            }
        }

        Console.WriteLine(positivo+" valores positivos");
        Console.WriteLine("{0:0.0}", soma/positivo);
    }
}