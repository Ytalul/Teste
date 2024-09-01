
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibeiraoPretoTeste
{
    public class Fibonacci
    {
        public Fibonacci(int numTarget) {
            int A=0;
            int B=1;
            for (int i = 0; i <= numTarget; i++)
            {
                int temp = A + B;
                A = B;
                B = temp;
                if (B == numTarget)
                {
                    System.Console.WriteLine($"Numero {numTarget} presente na sequência de fibonacci.");
                    break;
                }
            }


        }
    }
}
