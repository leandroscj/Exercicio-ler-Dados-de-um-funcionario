using System;

namespace Exercicio_ler_Dados_de_um_funcionario
{
    static class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.WriteLine("Nome:");
            F.Nome = Console.ReadLine();

            Console.WriteLine("Salário bruto:");
            F.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto:");
            F.Imposto = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Funcionario: " +F);

            Console.Write("Digite a porcentagem para aumentar:");
            int p = int.Parse(Console.ReadLine());
            F.AumentarSalario(p);

            Console.WriteLine("Dados atualizados: " + F);





        }
    }
}
