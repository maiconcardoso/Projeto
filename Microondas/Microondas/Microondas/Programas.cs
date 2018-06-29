using System;

namespace Microondas
{
    class Programas
    {
        int potencia = 0;
        int tempoSegundos = 0;
        string comida;
        string pontos;
        string totalPontos;
        string opcao;
        int i;
        int[] quantProgramas = new int[10];
        string[] cadComida = new string[10];
        int[] cadPotencia = new int[10];
        int[] cadTempoSegundos = new int[10];


        //Exibição de Aquecimento
        public void exibirProgramas()
        {
            Console.WriteLine("=========  PROGRAMA DE AQUECIMENTO  ===========");
            Console.WriteLine("===============================================");
            Console.WriteLine("Digite o nome da comida para iniciar a programa");
            Console.WriteLine("===============================================");
            Console.WriteLine("=================== [carne] ===================");
            Console.WriteLine("=================== [frango] ==================");
            Console.WriteLine("=================== [peixe] ===================");
            Console.WriteLine("=================== [feijao] ==================");
            for (int j = 1; j <= quantProgramas[i]; j++)
            {
                Console.WriteLine("=================== [" + cadComida[j] + "] ================");
            }
            Console.WriteLine("===============================================");
            comida = Console.ReadLine();
            Console.Clear();
        }
        //Programas de Aquecimento
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
                    Console.Clear();
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
        public void esquentarComidaCriada()
        {
            int[] quantidade = getQuantProgramas();
            string[] cadComida = getCadComida();
            try
            {
                for (int j=1; j<=quantidade[i]; i++)
                {
                    if (comida == cadComida[j])
                    {
                        for (int i = 1; i <= potencia; i++)
                        {
                            totalPontos = totalPontos + (pontos + "@");
                        }
                        for (int i = 1; i <= tempoSegundos; i++)
                        {
                            Console.WriteLine(totalPontos);
                        }
                        Console.WriteLine();
                        Console.WriteLine(cadComida[j] + " Aquecida(o)......");
                    }
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }
        // Gerador de programas de aquecimento
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

            //Variável "j" serve para marcar o indice do array
            for (int j = 1; j <= quantProgramas[i]; j++)
            {
                try
                {
                    do
                    {
                        Console.WriteLine("===    CRIANDO PROGRAMA DE AQUECIMENTO     ====");
                        Console.WriteLine("===============================================");
                        Console.WriteLine("=======   Digite o nome da comida   ===========");
                        cadComida[j] = Console.ReadLine();
                        Console.Clear();
                    } while (cadComida[j] == "");
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
                        cadPotencia[j] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (cadPotencia[j] < 1 || cadPotencia[j] > 10);
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
                        cadTempoSegundos[j] = int.Parse(Console.ReadLine());
                        Console.Clear();
                    } while (cadTempoSegundos[j] < 1 || cadTempoSegundos[j] > 120);
                }
                catch (Exception)
                {
                    Console.WriteLine("Informação inválida");
                }
            }
            Console.WriteLine("Deseja cadastrar mais? [s/n]");
            opcao = Console.ReadLine();
            Console.Clear();
            if (opcao.Equals("s"))
            {
                criarPrograma();
            }
        }

        // Consulta de Programas
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

        //Consulta de comida criada pelo usuario
        public void consultarComidaCriada()
        {
            try
            {
                for (int j = 1; j <= quantProgramas[i]; j++)
                {
                    if (comida == cadComida[j])
                    {
                        Console.WriteLine("AQUECIMENTO DE " + cadComida[j]);
                        Console.WriteLine("Potencia utilizada: " + cadPotencia[j] + "w");
                        Console.WriteLine("Tempo de aquecimento: " + cadTempoSegundos[j] + "s");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nome de Comida Inválida");
            }
        }

        //Getters e Setters
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
        public int[] getQuantProgramas()
        {
            return this.quantProgramas;
        }
        public void setQuantProgramas(int[] quantProgramas)
        {
            this.quantProgramas = quantProgramas;
        }
        public string[] getCadComida()
        {
            return this.cadComida;
        }
        public void setCadComida(string[] cadComida)
        {
            this.cadComida = cadComida;
        }
        public int[] getCadPotencia()
        {
            return this.cadPotencia;
        }
        public void setCadPotencia(int[] cadPotencia)
        {
            this.cadPotencia = cadPotencia;
        }
        public int[] getCadTempoSegundos()
        {
            return this.cadTempoSegundos;
        }
        public void setCadTempoSegundos(int[] cadTempoSegundos)
        {
            this.cadTempoSegundos = cadTempoSegundos;
        }
    }
}
