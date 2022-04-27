using System; 

class URI {

    static void Main(string[] args) { 

        int x, y;
        do{
            string[] linha = Console.ReadLine().Split();

            x = int.Parse(linha[0]);
            y = int.Parse(linha[1]);

            if(x==y)
                continue;

            if(x>y)
                Console.WriteLine("Decrescente");
            else 
                Console.WriteLine("Crescente");
        }while(x!=y);

    }

}