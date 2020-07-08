using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_ler_Dados_de_um_funcionario
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
             Salario = Salario + (Salario * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2");



        }
    }
}
