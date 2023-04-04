internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("1 - ad.");
        Console.WriteLine("2 - sub.");
        Console.WriteLine("3 - mul.");
        Console.WriteLine("4 - div.");

        int operacao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero");
        int primeiroNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero");
        int segundoNum = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case 1:
                {
                    resultado = Adicao(primeiroNum, segundoNum);
                    break;
                }
            case 2:
                {
                    resultado = Subtracao(primeiroNum, segundoNum);
                    break;
                }
            case 3:
            {
                resultado = Multiplicacao(primeiroNum, segundoNum);
                break;
            }
            case 4:
            {
                resultado = Divisao(primeiroNum, segundoNum);
                break;
            }
        }

        static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

        Console.WriteLine("resultado da operação com os números " + primeiroNum + " e " + segundoNum + " é: "+ resultado);



    }
}