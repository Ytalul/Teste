using System.Numerics;

namespace RibeiraoPretoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fiz  os métodos usando construtores pra facilitar

            // Passe o parâmetro do número que vocês quer verificar se está na sequencia de fibonacci
            Fibonacci fibonacci = new Fibonacci(5);

            // Passe o parâmetro da string que vocês quer verificar a quantidade de letras A
            ContarLetrasA teste2 = new ContarLetrasA("Ytalo");

            // Exercício 3 
            // Resposta : A variável soma no fim será igual a 77 

            // 4) Descubra a lógica e complete o próximo elemento:
            //a) 1, 3, 5, 7, 9
            //b) 2, 4, 8, 16, 32, 64, 128
            //c) 0, 1, 4, 9, 16, 25, 36, 49
            //d) 4, 16, 36, 64, 100
            //e) 1, 1, 2, 3, 5, 8, 13
            //f) 2,10, 12, 16, 17, 18, 19, 20

            //Exercício 5 
            /*
             Considerando que existe as salas 1,2 e 3;
             1. Deixaria dois interruptores ligados e iria até a sala 1.
             2. Se a sala 1 estiver apagada, eu sei qual interruptor está relacionado a está sala, é o que eu não liguei.
             3. Portanto, o interruptor 1 está ligado a sala 1, só falta descobrir qual interruptor está ligado a sala 2.
             4. Desligo um interruptor que estava ligado antes e vou até a sala 2.
             5. Se a sala 2 estiver apagada, eu sei que o interruptor 2 está ligado a sala 2.
             6. Se não, o interruptor 2 está ligado a sala 3.
             */

        }
    }
}
