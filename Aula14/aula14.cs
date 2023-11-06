using System;

class Aula14 {
    static void Main() {

        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado;

        Console.Write("Digite sua primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite sua segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite sua terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite sua quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;
        
        if(res >= 6) {
            if(res >= 9) {
                if(res == 10) {
                    resultado = "Super aprovado!";
                }
                else {
                    resultado = "Aprovado com louvor!";
                }
            }
            else {
                resultado = "Aprovado!";
            }
        }
        else {
            if(res > 4) {
                resultado = "Recuperação!";
            }
            else {
                resultado  = "Reprovado!";
            }
        }

        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
    }
}