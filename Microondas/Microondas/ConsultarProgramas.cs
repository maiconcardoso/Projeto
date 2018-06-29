using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class ConsultarProgramas
    {
        int potencia = 0;
        int tempoSegundos = 0;
        string comida;
        CriarProgramaAquecimento criar = new CriarProgramaAquecimento();
        
        public void gerarProgramaAque()
        {
            
        }
        public void exibirProgramasConsulta()
        {
            Console.WriteLine("===========  PROGRAMA DE CONSULTA =============");
            Console.WriteLine("===============================================");
            Console.WriteLine("=== Digite o nome da comida para consultar ====");
            Console.WriteLine("===============================================");
            Console.WriteLine("===== [carne] [frango] [peixe] [feijao]" + criar.getComida() + "=======");
            Console.WriteLine("===============================================");
            comida = Console.ReadLine();
            Console.Clear();
        }
        public void consultarCarne()
        {
            try
            {
                if (comida.Equals("carne"))
                {
                    potencia = 6;
                    tempoSegundos = 100;
                    Console.WriteLine("AQUECIMENTO DE CARNE");
                    Console.WriteLine("Potencia utilizada: " + potencia + "w");
                    Console.WriteLine("Tempo de aquecimento: " + tempoSegundos + "s");
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void consultarFrango()
        {
            try
            {
                if (comida.Equals("frango"))
                {
                    potencia = 5;
                    tempoSegundos = 80;
                    Console.WriteLine("AQUECIMENTO DE FRANGO");
                    Console.WriteLine("Potencia utilizada: " + potencia + "w");
                    Console.WriteLine("Tempo de aquecimento: " + tempoSegundos + "s");
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void consultarPeixe()
        {
            try
            {
                if (comida.Equals("peixe"))
                {
                    potencia = 7;
                    tempoSegundos = 50;
                    Console.WriteLine("AQUECIMENTO DE PEIXE");
                    Console.WriteLine("Potencia utilizada: " + potencia + "w");
                    Console.WriteLine("Tempo de aquecimento: " + tempoSegundos + "s");
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        public void consultarFeijao()
        {
            try
            {
                if (comida.Equals("feijao"))
                {
                    potencia = 8;
                    tempoSegundos = 120;
                    Console.WriteLine("AQUECIMENTO DE FEIJAO");
                    Console.WriteLine("Potencia utilizada: " + potencia + "w");
                    Console.WriteLine("Tempo de aquecimento: " + tempoSegundos + "s");
                    Console.WriteLine();
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
