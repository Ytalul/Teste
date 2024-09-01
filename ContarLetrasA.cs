using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibeiraoPretoTeste
{
    internal class ContarLetrasA
    {
        public ContarLetrasA(String s) {
            String sentence = s.ToUpper();
            int counter = 0;

            for (int i = 0; i<sentence.Length; i++)
            {
                if (sentence[i] == 'A') { counter++;}
            }

            Console.Write($"A letra 'A' apareceu {counter} vezes. ");
        }
    }
}
