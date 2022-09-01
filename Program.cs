using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Conversion
            // int numInteiro = 1;
            // // numInteiro = (int)2.6; //2
            // numInteiro = Convert.ToInt32(2.6); // 3
            // Console.WriteLine(numInteiro);

            // Operators
            // int atrNum = 5;
            // atrNum -= 2;
            // atrNum++;
            // Console.WriteLine(atrNum);

            // Switch
            // string flor = "girassol";
            // switch (flor)
            // {
            //     case "tulipa":
            //         Console.WriteLine("Não é essa.");
            //         break;
            //     case "margarida":
            //         Console.WriteLine("Essa é a errada.");
            //         break;
            //     case "rosa":
            //         Console.WriteLine("Essa é a certa.");
            //         break;
            //     default:
            //         Console.WriteLine("Continue colhendo!");
            //         break;
            // }


            // Functions
            // MeuMetodo();
            // string nome = NomeCompleto("Stella", "Leal");
            // Console.WriteLine(nome);

            // Value types and Reference Types
            int x = 25;
            int y = x;
            Console.WriteLine($"{x} {y}");
            x = 32;
            Console.WriteLine($"{x} {y}");

            var arr = new string[2];
            arr[0] = "Item 1";
            var arr2 = arr;
            Console.WriteLine($"{arr[0]} {arr2[0]}");
            arr[0] = "Item 1 Modificado";
            Console.WriteLine($"{arr[0]} {arr2[0]}");

        }

        static void MeuMetodo()
        {
            Console.WriteLine("C#");
        }

        static string NomeCompleto(
            string nome,
            string sobrenome,
            int idade = 20,
            bool teste = false
        )
        {
            return nome + " " + sobrenome;
        }
    }
}
