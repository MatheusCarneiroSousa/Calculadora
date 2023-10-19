using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Calculadora_2
{
    internal class Operations
    {
        public void Validation(double k)
        {
            while (true)
            {
                try
                {
                    k = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("A entrada não é valida");
                    break;
                }
            }
        }
        public void SumValues(double a, double b)
        {
            double Sum = a + b;
            Console.WriteLine("A soma dos valores é " + Sum);
        }
        public void SubValues(double a, double b)
        {
            double Sub = a - b;
            Console.WriteLine("A subtração dos valores é "+ Sub);
        }
        public void MulValues(double a, double b)
        {
            double Result = 0;
            for (double i = 0; i < b; i++)
            {
                Result += a;
            }
            Console.WriteLine("A multiplicação dos valores é " + Result);
        }
        public void DivValues(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("A divisão por zero é impossível");
            }
            else
            {
                double Result = 0;
                while (a >= b)
                {
                    a -= b;
                    Result++;
                }
                Console.WriteLine("A divisão inteira dos valores é " + Result);
                // Não consegui fazer a divisão fracionária, apenas a inteira
            }
        }
    }
}
