using System; 
class URI {
    static void Main(string[] args) { 

        int par=0;
        for(int i=0; i<5; i++) {
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
                par++;
        }

        Console.WriteLine(par+" valores pares");
    }
}