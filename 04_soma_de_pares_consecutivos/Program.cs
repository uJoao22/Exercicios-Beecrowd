using System; 

class URI {

    static void Main(string[] args) { 
    
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int maior = x > y ? x : y;
        int menor = x < y ? x : y;
        int soma=0;

        for(int i=menor+1; i<maior; i++) {
            if(i%2!=0)
                soma+=i;
        }

        Console.WriteLine(soma);

    }

}