using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double cf, comissao, impostos, custo_final;

            Console.Write("Informe o custo de fábrica do veículo: ");
            cf = double.Parse(Console.ReadLine());

            comissao = cf * (25.0 / 100.0);
            impostos = cf * (45.0 / 100.0);

            custo_final = cf + comissao + impostos;
            //custo_final = cf + (cf * (25.0/100.0)) + (cf * (45.0/100.0));

            Console.WriteLine("Valor da Comissão do vendedor => {0:N}", comissao);
            Console.WriteLine("Valor dos Impostos => {0:N}", impostos);
            Console.WriteLine("Custo Final do Veículo => {0:N}", custo_final);

            Console.ReadKey();

        }
    }
}
