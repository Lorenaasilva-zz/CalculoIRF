using System;



namespace IRFJoao

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Vamos encontrar o valor liquído do seu salário?");

            Console.Write("Digite o seu salário: ");

            double salario;

            double salarioTotal;

            salario = double.Parse(Console.ReadLine());



            if (salario < 1903.98)

            {

                Console.WriteLine("Você recebera os R$ " + salario + " reais sem deduções do IRF.");

            }

            if ((salario > 1903.98) && (salario < 2806.25))

            {

                double Irf = (0.075 * salario);

                Console.WriteLine("Neste caso, sua dedução sera de R$ " + Math.Round(Irf, 2) + " reais");

                salarioTotal = salario - Irf;

                Console.WriteLine("Por isso seu salário liquido terá um valor de R$ " + Math.Round(salarioTotal, 2) + "reais");

            }

            if ((salario > 2826.66) && (salario < 3751.05))

            {

                double Irf = (0.15 * salario);

                Console.WriteLine("Neste caso, sua dedução sera de R$ " + Math.Round(Irf, 2) + " reais");

                salarioTotal = salario - Irf;

                Console.WriteLine("Por isso seu salário liquido terá um valor de R$ " + Math.Round(salarioTotal, 2) + " reais.");

            }

            if ((salario > 3751.06) && (salario < 4664.68))

            {

                double Irf = (0.225 * salario);

                Console.WriteLine("Neste caso, sua dedução sera de R$ " + Math.Round(Irf, 2) + " reais");

                salarioTotal = salario - Irf;

                Console.WriteLine("Por isso seu salário liquido terá um valor de R$ " + Math.Round(salarioTotal, 2) + " reais.");

            }

            if (salario > 4664.68)

            {

                double Irf = (0.275 * salario);

                Console.WriteLine("Neste caso, sua dedução sera de R$ " + Math.Round(Irf, 2) + " reais");

                salarioTotal = salario - Irf;

                Console.WriteLine("Por isso seu salário liquido terá um valor de R$ " + Math.Round(salarioTotal, 2) + " reais.");

            }

            Console.ReadLine();
        }

    }

}