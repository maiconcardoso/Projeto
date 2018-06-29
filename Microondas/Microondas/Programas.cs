using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class Programas
    {
        int potencia = 0;
        int tempoSegundos = 0;
        string pontos;
        string totalPontos;
        string comida;

        public void exibirProgramas()
        {
            Console.WriteLine("=========  PROGRAMA DE AQUECIMENTO  ===========");
            Console.WriteLine("===============================================");
            Console.WriteLine("Digite o nome da comida para iniciar a programa");
            Console.WriteLine("===============================================");
            Console.WriteLine("===== [carne] [frango] [peixe] [feijao] =======");
            Console.WriteLine("===============================================");
            comida = Console.ReadLine();
            Console.Clear();
        }
        public void esquentarCarne()
        {
            try
            {
                if (comida.Equals("carne"))
                {
                    potencia = 6;
                    tempoSegundos = 100;
                    for (int i = 1; i <= potencia; i++)
                    {
                        totalPontos = totalPontos + (pontos + "#");
                    }
                    for (int i = 1; i <= tempoSegundos; i++)
                    {
                        Console.WriteLine(totalPontos);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Carne Aquecida......");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void esquentarFrango()
        {
            try
            {
                if (comida.Equals("frango"))
                {
                    potencia = 5;
                    tempoSegundos = 80;
                    for (int i = 1; i <= potencia; i++)
                    {
                        totalPontos = totalPontos + (pontos + "=");
                    }
                    for (int i = 1; i <= tempoSegundos; i++)
                    {
                        Console.WriteLine(totalPontos);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Frango Aquecido......");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void esquentarPeixe()
        {
            try
            {
                if (comida.Equals("peixe"))
                {
                    potencia = 7;
                    tempoSegundos = 50;
                    for (int i = 1; i <= potencia; i++)
                    {
                        totalPontos = totalPontos + (pontos + "%");
                    }
                    for (int i = 1; i <= tempoSegundos; i++)
                    {
                        Console.WriteLine(totalPontos);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Peixe Aquecido......");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void esquentarFeijao()
        {
            try
            {
                if (comida.Equals("feijao"))
                {
                    potencia = 8;
                    tempoSegundos = 120;
                    for (int i = 1; i <= potencia; i++)
                    {
                        totalPontos = totalPontos + (pontos + "@");
                    }
                    for (int i = 1; i <= tempoSegundos; i++)
                    {
                        Console.WriteLine(totalPontos);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Feijão Aquecido......");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public int getPotencia()
        {
            return this.potencia;
        }
        public void setPotencia(int potencia)
        {
            this.potencia = potencia;
        }
        public int getTempoSegundos()
        {
            return this.tempoSegundos;
        }
        public void setTemposSegundos(int tempoSegundos)
        {
            this.tempoSegundos = tempoSegundos;
        }
        public string getTotalPontos()
        {
            return this.totalPontos;
        }
        public void setTotalPontos(string totalPontos)
        {
            this.totalPontos = totalPontos;
        }
        public string getComida()
        {
            return this.comida;
        }
        public void setComida(string comida)
        {
            this.comida = comida;
        }
    }
}
