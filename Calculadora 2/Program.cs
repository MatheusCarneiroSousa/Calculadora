using Calculadora_2;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber;
            double SecondNumber;
            int Choice;
            Operations op = new Operations();
            while (true)
            {

                Console.Write("Digite o valor do primeiro número: ");
                try
                {
                    FirstNumber = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("A entrada não é valida");
                    break;
                }
                Console.Write("Digite o valor do segundo número: ");
                try
                {
                    SecondNumber = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("A entrada não é valida");
                    break;
                }
                Console.WriteLine("==== Operações ====");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Digite o código da operação desejada: ");
                try
                {
                    Choice = int.Parse(Console.ReadLine());
                                    while (Choice > 4 || Choice < 1)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Digite uma operação válida");
                    Console.Write("Digite o código da operação desejada: ");
                    Choice = int.Parse(Console.ReadLine());
                }
                if (Choice == 1)
                {
                    op.SumValues(FirstNumber, SecondNumber);
                }
                if (Choice == 2)
                {
                    op.SubValues(FirstNumber, SecondNumber);
                }
                if (Choice == 3)
                {
                    op.MulValues(FirstNumber, SecondNumber);
                }
                if (Choice == 4)
                {
                    op.DivValues(FirstNumber, SecondNumber);
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine("A entrada não é válida");
                }

                Console.WriteLine("======================");
                Console.WriteLine("Deseja fazer outra operação?");
                Console.Write("Aperte Enter para Continuar ou Digite 'SAIR' para finalizar: ");
                string Continue = Console.ReadLine().ToUpper();
                if (Continue == "SAIR")
                {
                    Console.WriteLine("Volte sempre Joe ^^");
                    break;
                }
            }
        }
    }
}
