using System;

namespace AtividadesDeRevisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"-= CALCULO DE CONSUMO DE ENERGIA =-");

            Console.WriteLine($"Digite o valor do salário minimo");
            double SalarioMinimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Digite a quantidade de qwatts gasta na empresa");
            double EnergiaGasta = Convert.ToDouble(Console.ReadLine());

            double UmSetimo = SalarioMinimo / 7;
            double UmQwatss = UmSetimo / 100;
            double Calculo = EnergiaGasta * UmQwatss;
            double Desconto = (Calculo * 10) / 100;
            double Pagamento = Calculo - Desconto;
            Console.Clear();

            Console.WriteLine($"O valor em reais de cada quilowatt: { UmQwatss } Reais");
            Console.WriteLine($"O valor em reais a ser pago: { Calculo } Reais");
            Console.WriteLine($"Com 10% de desconto será pago: { Pagamento } Reais");

            Console.ReadKey();



        }
    }
}
