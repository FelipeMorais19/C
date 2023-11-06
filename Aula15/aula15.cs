using System;

class Aula15 {
    static void Main() {
        int tempoMinuto = 0;
        char escolha;
        double tempoHora = 0;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");

        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a':
            case 'A':
                tempoMinuto = 60;
                break;
            
            case 'c':
            case 'C':
                tempoMinuto = 480;
                break;
            
            case 'o':
            case 'O':
                tempoMinuto = 660;
                break;

            default:
                tempoMinuto = -1;
                break;
        }

        tempoHora = tempoMinuto / 60;

        if(tempoMinuto < 0) {
            Console.WriteLine("Transporte indisponível");
        }
        else {
            Console.WriteLine("Para o tranposte escolhido, o tempo é: {0} horas", tempoHora);
        }
    }
}