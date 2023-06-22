using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mes;
            int dia;
            string periodo;

            Console.WriteLine(" \n \n BEM-VINDO A COMPANHIA AEREa CONRAD");
            Console.WriteLine(" \n Temos passagens disponiveis para: \n ");
            Console.WriteLine(" - 08 de Agosto");
            Console.WriteLine(" - 09 de Setembro");
            Console.WriteLine(" - 10 de Outubro \n ");
                 mes = int.Parse(Console.ReadLine());

            if (mes > 7 && mes < 11) 
            {
                Console.WriteLine("MÊS VÁLIDO");
            }

            else
            {
                Console.WriteLine("MÊS INVÁLIDO");
            }

            Console.WriteLine(" \n \n- Escolha o melhor dia para sua viagem entre os dias 6 ao dia 21 \n ");
            dia = int.Parse(Console.ReadLine());

            if(dia > 6 && dia < 21)
            {
                Console.WriteLine("DATA MARCADA!");
            }

            Console.WriteLine(" \n \n --ESCOLHA O MELHOR HORARIO PARA SUA VIAGEM:");
            Console.WriteLine("- TARDE ");
            Console.WriteLine("- MANHÃ ");
            Console.WriteLine("- NOITE");
                periodo = Console.ReadLine();

            Console.WriteLine(" \n \n \n PASSAGEM COMPRADA COM SUCESSO! ");

            Console.WriteLine($"VIAGEM MARCADA PAR O DIA {dia} MÊS {mes} PERIODO {periodo}!");






            Console.ReadKey();

        }
    }
}
