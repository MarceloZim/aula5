using System;

namespace AtividadesDeRevisao
{
    class Program
    {
        static void Main(string[] args)
        {


            //ATIVIDADE 1   ##################################################################################################################################### 
            /*
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

            Console.ReadKey(); */

            //ATIVIDADE 2   #####################################################################################################################################
            /*
            Console.WriteLine($"-= Programa  para aplicar 9% desconto =-");
            Console.WriteLine($"Digite o valor do produto");
            double Preco = Convert.ToDouble(Console.ReadLine());

            double Calculo = (Preco * 10) / 100;
            double NewValor = Preco - Calculo;
            Console.WriteLine($"{ Preco } com desconto de 9% fica: { NewValor } real."); */

            //ATIVIDADE 3   #####################################################################################################################################
            /*
            Console.WriteLine("-= CALCULO DO SALÁRIO LIQUIDO DO PROFESSOR =-");

            Console.WriteLine($"Digite seu nome:");
            var Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu salario:");
            double Salario = Convert.ToDouble(Console.ReadLine());

            double CalculoDia = Salario / 30;
            double CalculoHor = CalculoDia / 9;
            double Desconto = (Salario * 11) / 100;
             
            Console.WriteLine($"{ Nome } com salario de: { Salario }, ganha por dia: { CalculoDia }, e por hora: { CalculoHor }.Descontando 11% de INSS seu salario é de: {Salario - Desconto}");

            //double Inss = numero * 100 / 11 */

            //ATIVIDADE 4   #####################################################################################################################################
            /*
            Console.WriteLine($"-= GORJETA DO GARÇOM =-");

            Console.WriteLine($"Digite o valor gasto no restaurante:");
            double ValorTotal = Convert.ToDouble(Console.ReadLine());
            double Calculo = (ValorTotal * 10) / 100;
            double Total = Calculo + ValorTotal;

            Console.WriteLine($"Valor gasto no restaurante é de { ValorTotal } Reais, com a gorjeta de { Calculo } Reais, fica no valor de: { Total } Reais");
            */

            //ATIVIDADE 5   ########################################## NÃO ENTENDI ################################################################
            /*
            Console.WriteLine($"Digite o valor que você desenha depositar para aplicação programada :");
            double ValorM = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Digite em até quantas vezes será feito essa aplicação :");
            double Qtd = Convert.ToInt32(Console.ReadLine());
            double taxa = 10;

            double Calculo = ValorM * ();
            Console.WriteLine("Resultado :"+Calculo);*/

            //ATIVIDADE 6. Entrar com um número e imprimi-lo caso seja maior que 20.
            /*
            Console.WriteLine("Digite uma valor :");
            double Valor = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Valor > 20)
            {
                Console.WriteLine($"{ Valor } é maios que >> 20 << .");
            }
            else
            {
                Console.WriteLine($"Valor não é maior que >> 20 << .");
            }*/

            //7.Construir um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá - lo.
            /*
            Console.WriteLine("SOMA DE DOIS NUMEROS, SERA QUE DA MAIS QUE 10 OU MENOS?");

            Console.WriteLine("Digite o primeiro numero :");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero :");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int Calculo = N1 + N2;

            if (Calculo > 10)
            {
                Console.WriteLine($"{ Calculo } é maior que 10");
            }
            else
            {
                Console.WriteLine("A soma entre os numeros não foi maior que 10");
            }*/

            //ATIVIDADE 8   #####################################################################################################################################
            /*
            Console.WriteLine("Digite o primeiro numero :");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero :");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int Calculo = N1 + N2;

            if (Calculo > 20)
            {
                Console.WriteLine($"Valor da soma foi maior que 20, será feito adição de +8 = { Calculo + 8 }");
            }
            else if (Calculo < 20)
            {
                Console.WriteLine($"Valor da soma foi menmor que 20, será feito subtração de -5 = { Calculo + 8 }");
            }*/

            //ATIVIDADE 9   ################################### NÃO FIZ ######################################################

            //ATIVIDADE 10   #####################################################################################################################################
            /*
            Console.WriteLine("Digite um numero");
            int Numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero > 20 &&  Numero < 90 )
            {
                Console.WriteLine($"{ Numero } está entre o numero 20 e 90 !");
            }
            else
            {
                Console.WriteLine($"{ Numero } Não está entre o numero 20 e 90");
            }*/

            //ATIVIDADE 11   #####################################################################################################################################

            /*
            Console.WriteLine("Digite um numero");
            int Numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero > 20)
            {
                Console.WriteLine($"{ Numero } é MAIOR que 20!");
            }
            else if (Numero < 20)
            {
                Console.WriteLine($"{ Numero } é MENOR que 20");
            }
            else
            {
                Console.WriteLine($"{ Numero } é IGUAL a 20");
            }*/

            //*ATIVIDADE 12. Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo feminino e tiver menos que 25 #################################
            //               anos, imprimir nome e a mensagem: ACEITA.Caso contrário, imprimir nome e a mensagem: NÃO ACEITA
            /*
            Console.WriteLine("Digite seu nome :");
            var Nome = Console.ReadLine();
            Console.WriteLine("Digite 1 - para Masculino | 2 - para Feminino :");
            int Sexo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual sua idade?");
            int Idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Sexo == 2 && Idade < 25)
            {
                Console.WriteLine($" { Nome } É ACEITO(A).");
            }
            else
            {
                Console.WriteLine($" { Nome } NÃO é aceito(A).");
            }*/

            //ATIVIDADE 13 Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens:**********######################################################
            /*
            Console.WriteLine("Digite as iniciais do seu estado (EM MAIUSCOLO) :");
            var Estado = Console.ReadLine();
            Console.Clear();
            if (Estado == "SC")
            {
                Console.WriteLine($"Quem é de { Estado } é catarinense.");
            }else if (Estado == "SP")
            {
                Console.WriteLine($"Quem é de { Estado } é paulista.");
            }
            else if (Estado == "MG")
            {
                Console.WriteLine($"Quem é de { Estado } é mineiro.");
            }
            else if (Estado == "RJ")
            {
                Console.WriteLine($"Quem é de { Estado } é carioca.");
            }
            else
            {
                Console.WriteLine("Não encontrado.");
            }*/

            // ATIVIDADE - = 14. Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se são iguais ou diferentes.
            /*
            Console.WriteLine("Verificação se o numero é igual ou diferente !");
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            
            if (Numero1 == Numero2)
            {
                Console.WriteLine($"{ Numero1 } e { Numero2 } são IGUAIS !");
            }
            else
            {
                Console.WriteLine($"{ Numero1 } e { Numero2 } são DIFERENTES !");
            }*/

            //15. Entrar com dois números e imprimir o maior numero (suponha números diferentes).#################################################################

            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero1 > Numero2)
            {
                Console.WriteLine($"{ Numero1 } é o maior !");
            }
            else
            {
                Console.WriteLine($"{ Numero2 } é maior !");
            }*/

            //16.Entrar com dois números e imprimir o menor numero(suponha números diferentes).#################################################################

            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero1 < Numero2)
            {
                Console.WriteLine($"{ Numero1 } é o menor !");
            }
            else
            {
                Console.WriteLine($"{ Numero2 } é menor !");
            }*/


            //17.Entrar com dois números e imprimi - los em ordem crescente(suponha números diferentes).#######################################################
            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero1 > Numero2)
            {
                Console.WriteLine($"{ Numero2 }-{ Numero1 }");
            }
            else
            {
                Console.WriteLine($"{ Numero1 }-{ Numero2 }");
            }*/


            //18.Entrar com dois números e imprimi - los em ordem decrescente(suponha números diferentes)########################################################
            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero1 > Numero2)
            {
                Console.WriteLine($"{ Numero1 }-{ Numero2 }");
            }
            else
            {
                Console.WriteLine($"{ Numero2 }-{ Numero1 }");
            }*/


            //19.Entrar com três números e imprimir o maior numero(suponha números diferentes). #################################################################
            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero:");
            int Numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (Numero1 > Numero2 && Numero1 > Numero3)
            {
                Console.WriteLine($"{ Numero1 } é o maior numero.");
            }
            else if (Numero2 > Numero1 && Numero2 > Numero3)
            {
                Console.WriteLine($"{ Numero2 } é o maior numero.");
            }
            else
            {
                Console.WriteLine($"{Numero3} é o maior numero");
            }*/

            //20 / 21 .Entrar com três números e imprimi - los em ordem crescente(suponha números diferentes).#########################################################
            /*
            Console.WriteLine("Digite o primeiro numero:");
            int Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            int Numero3 = Convert.ToInt32(Console.ReadLine());
            
            if (Numero1 < Numero2 && Numero2 < Numero3)
            {
                Console.WriteLine($"{ Numero1 } - { Numero2 } - { Numero3 } ");
            }
            else if (Numero2 > Numero1 && Numero1 < Numero3 )
            {
                Console.WriteLine($"{ Numero1 } - { Numero2 } - { Numero3 } ");
            }
            else
            {
                Console.WriteLine($"{ Numero2 } - { Numero3 } - { Numero1 } ");
            }*/

            //22. Entrar com três números e armazená-los em três variáveis com seguintes nomes: maior, intermediário e menor(suponha números diferentes).
            /*
            Console.WriteLine("DIGITE UM NUMERO: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIGITE UM SEGUNDO NUMERO: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIGITE UM TERCEIRO NUMERO: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if ((num1 > num2) && (num2 > num3))
            {
                int menor = num3;
                int inter = num2;
                int maior = num1;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");
            }
            else if ((num2 > num1) && (num3 > num1))
            {
                int menor = num1;
                int inter = num3;
                int maior = num2;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");

            }
            else if ((num3 > num2) && (num2 > num1))
            {
                int menor = num1;
                int inter = num2;
                int maior = num3;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");
            }
            else if ((num3 > num1) && (num1 > num2))
            {
                int menor = num2;
                int inter = num1;
                int maior = num3;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");
            }
            else if ((num1 > num3) && (num3 > num2))
            {
                int menor = num2;
                int inter = num3;
                int maior = num1;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");
            }
            else if ((num2 > num1) && (num1 > num3))
            {
                int menor = num3;
                int inter = num1;
                int maior = num2;
                Console.WriteLine($"Menor:{ menor } | Intermediario: { inter } | Maior: { maior }");
            }
            else
            {
                Console.WriteLine("DIGITE NUMEROS DISTINTOS!!");
            }*/

            //24.Entrar com a idade de uma pessoa e informar: |• Se é maior de idade |• Se é menor de idade |• Se é maior de 65 anos 
            /*
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine()); 

            if (idade > 65)
            {
                Console.WriteLine("Idade maior que 65 anos!");
            }
            else if (idade >= 18 || idade > 65)
            {
                Console.WriteLine("Você é maior de idade!");
            }else if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade!");
            }*/

            //25.Entrar com nome, nota da PR1 e nota da PR2 de um aluno, imprimir nome, nota da PR1, nota da PR2#################################################

            /*
            Console.WriteLine("Digite seu nome:");
            var Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota da PR1:");
            double N1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Digite a nota da PR2:");
            double N2 = Convert.ToInt64(Console.ReadLine());
            Console.Clear();

            double Calculo = (N1 + N2) / 2;

            if (Calculo >= 7)
            {
                Console.WriteLine($"{ Nome } tirou média: { Calculo } e está APROVADO!");
            }
            else if (Calculo <= 3)
            {
                Console.WriteLine($"{ Nome } tirou média: { Calculo } e está REPROVADO!");
            }
            else
            {
                Console.WriteLine($"{ Nome } tirou média: { Calculo } e está em EXAME!");
            }*/


            string[] Nome = {"Marcelo"};

            Console.WriteLine(Nome[0]);






































        }
    }
}