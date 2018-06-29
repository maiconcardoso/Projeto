using System;

namespace Microondas
{
    class LigarMicroOndas
    { 
        int potencia = 0;
        int tempoSegundos = 0;
        string pontos;
        string totalPontos;

        public LigarMicroOndas()
        {
            this.potencia = 8;
            this.tempoSegundos = 30;
        }
        public void ligarMicro()
        {
            try
            {
                do
                {
                    Console.WriteLine("Insira o valor da potencia entre [1w - 10w]");
                    potencia = int.Parse(Console.ReadLine());
                } while (potencia < 1 || potencia > 10);
            }
            catch (Exception)
            {
                potencia = 10;
            }
            try
            {
                do
                {
                    Console.WriteLine("Insira o valor do tempo em segundos entre [1s - 120s]");
                    tempoSegundos = int.Parse(Console.ReadLine());
                } while (tempoSegundos < 1 || tempoSegundos > 120);

            }
            catch (Exception)
            {
                tempoSegundos = 30;
            }
            for (int i = 1; i<=potencia; i++)
            {
                totalPontos = totalPontos + (pontos + ".");
            }
            for(int i = 1; i<=tempoSegundos; i++)
            {
                Console.WriteLine(totalPontos);
            }
            Console.WriteLine();
            Console.WriteLine("Comida Aquecida......");
        }
        public void rapidoAquecimento()
        {
            this.potencia = 8;
            this.tempoSegundos = 30;

            for (int i = 1; i <= potencia; i++)
            {
                totalPontos = totalPontos + (pontos + ".");
            }
            for (int i = 1; i <= tempoSegundos; i++)
            {
                Console.WriteLine(totalPontos);
            }
            Console.WriteLine("Potencia padrão: " + potencia + "w");
            Console.WriteLine("Tempo para aquecimento rápido: " + tempoSegundos + "s");
            Console.WriteLine();
            Console.WriteLine("Comida Aquecida......");
            Console.WriteLine();
        }
        //Getters e Setters
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
    }
}
