using System;

namespace HelloWorld {
    class CondicionaisELoops {
        static void Main(string[] args) {

            /* Condicionais */

            // Condicional If

            int numero = 0;

            if(numero > 0) {
                Console.WriteLine("Número é maior que zero: " + numero);
            } else if(numero < 0) {
                Console.WriteLine("O número é negativo:" + numero);
            }else {
                Console.WriteLine("O número é igual a zero:" + numero);
            }

            // Condicional Switch

            char letra = 'C';
            switch (letra) {
                case 'A':
                    Console.WriteLine("A letra é A.");
                    break;
                case 'B':
                    Console.WriteLine("A letra é B.");
                    break;
                default:
                    Console.WriteLine("A letra não é A e nem B. A letra é " + letra);
                    break;
            }

            /* --- */

            /* Loops */

            // Loop For

            Console.WriteLine("Loop For:");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("i = " + i);
            }

            // Loop While

            Console.WriteLine("Loop While:");
            int j = 1;
            while (j <= 5) {
                Console.WriteLine("j = " + j);
                j++;
            }

            // Loop Foreach

            Console.WriteLine("Loop Foreach:");
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int l in numeros) {
                Console.WriteLine("l = " + l);
            }
        }
    }
}