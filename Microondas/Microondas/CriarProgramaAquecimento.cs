using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class CriarProgramaAquecimento
    {
        int[] quantProgramas = new int[10];
        string[] comida = new string[10];
        int[] potencia = new int[10];
        int[] tempoSegundos = new int[10];
        string opcao;
        int i = 0;

        public void criarPrograma()
        {
            do
            {
                quantProgramas[i] = 0;
                Console.WriteLine("===    CRIANDO PROGRAMA DE AQUECIMENTO     ====");
                Console.WriteLine("===============================================");
                Console.WriteLine("=====   Quantos programas deseja criar?   =====");
                quantProgramas[i] = int.Parse(Console.ReadLine());
                if (quantProgramas[i] == 0)
                {
                    Console.Clear();
                    Console.WriteLine("==  Quantidade inválida, tente novamente  =====");
                    Console.WriteLine("===============================================");

                }
            } while (quantProgramas[i] == 0);
            Console.Clear();
            for (int j=1; j<=quantProgramas[i]; j++)
            {
                try
                {
                    do
                    {
                        Console.WriteLine("===    CRIANDO PROGRAMA DE AQUECIMENTO     ====");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("=======   Digite o nome da comida   ===========");
                        comida[i] = Console.ReadLine();
                        Console.Clear();
                    } while (comida[i] == "");
                }
                catch (Exception)
                {
                    Console.WriteLine("Informação inválida");
                }

                try
                {
                    do
                    {
                        Console.WriteLine("===    CRIANDO PROGRAMA DE AQUECIMENTO     ====");
                        Console.WriteLine("===============================================");
                        Console.WriteLine(" Digite a potencia de aquecimento entre [1-10] ");
                        potencia[i] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (potencia[i] < 1 || potencia[i] > 10);
                }
                catch (Exception)
                {
                    Console.WriteLine("Informação inválida");
                }
                try
                {
                    do
                    {
                        Console.WriteLine("===    CRIANDO PROGRAMA DE AQUECIMENTO     ====");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("  Digite o tempo de aquecimento entre [1-120]  ");
                        tempoSegundos[i] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (tempoSegundos[i] < 1 || tempoSegundos[i] > 120);
                }
                catch (Exception)
                {
                    Console.WriteLine("Informação inválida");
                }
            }
            Console.WriteLine("Deseja cadastrar mais? [s/n]");
            opcao = Console.ReadLine();
            if (opcao.Equals("s"))
            {
                criarPrograma();
            }
            for (int i=0; i <= quantProgramas[i]; i++)
            {
                Console.WriteLine(comida[i]);
            }
        }
        
        public int[] getQuantProgramas()
        {
            return this.quantProgramas;
        }
        public void setQuantProgramas(int[] quantProgramas)
        {
            this.quantProgramas = quantProgramas;
        }
        public string[] getComida()
        {
            return this.comida;
        }
        public void setComida(string[] comida)
        {
            this.comida = comida;
        }
        public int[] getPotencia()
        {
            return this.potencia;
        }
        public void setPotencia(int[] potencia)
        {
            this.potencia = potencia;
        }
        public int[] getTempoSegundos()
        {
            return this.tempoSegundos;
        }
        public void setTempoSegundos(int[] tempoSegundos)
        {
            this.tempoSegundos = tempoSegundos;
        }

    }
}
