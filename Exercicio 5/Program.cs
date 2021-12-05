using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Salário bruto:");
                double salarioBruto = double.Parse(Console.ReadLine());

                Console.Write("Imposto:");
                double imposto = double.Parse(Console.ReadLine());

                Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

                Console.WriteLine($"\nFuncionário {funcionario}");

                Console.Write("\nDigite a porcentagem para aumentar o salário:");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcentagem);

                Console.WriteLine($"\nDados atualizados {funcionario}");

                Console.WriteLine("\nPressione qualquer tecla para finalizar");
                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($">{falha.Message}");
                Console.ReadKey();
            }
        }
    }
}
