//Requisito 01 
//Nossa calculadora deve ter a possibilidade de somar dois números [x]

//Requisito 02 
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma [x]

//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração [x]

//Requisito 04 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática [x]

//Requisito 05 
//Nossa calculadora deve realizar as operações com "0" [x]

//Requisito 06
//Nossa calculadora deve validar a opções do menu [x]

//Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais [ ]



namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {   Console.Clear();

                Console.WriteLine("Calculator Exxperience");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                Console.WriteLine("MENU");
                Console.WriteLine("Digite 1 para adição");
                Console.WriteLine("Digite 2 para subtração");
                Console.WriteLine("Digite 3 para multiplicação");
                Console.WriteLine("Digite 4 para divisão");

                Console.WriteLine("Digite S para sair");
                Console.WriteLine();

                string operacao = Console.ReadLine();

                if (operacao == "S" ||  operacao == "s")
                {
                    break;
                }
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "s")
                {
                    Console.WriteLine();
                    Console.Write("Opção inválida, digite novamente");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool adicao = operacao == "1";
                bool subtracao = operacao == "2";
                bool multiplicacao = operacao == "3";
                bool divisao = operacao == "4";

                if (adicao)
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (subtracao)
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (multiplicacao)
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (divisao)

                    while (segundoNumero == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                        Console.ReadLine();

                        Console.Write("Digite o segundo número: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }
                {
                    resultado = primeiroNumero / segundoNumero;
                }

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine();

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado);

                Console.ReadLine();
                
            } while (true);
        }
    }
}



