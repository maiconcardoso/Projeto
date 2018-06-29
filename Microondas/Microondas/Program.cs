using System;

namespace Microondas
{
    class Program
    {
        static void Main(string[] args)
        {
            LigarMicroOndas ligar = new LigarMicroOndas();
            Programas programa = new Programas();
            string entrada;
            int opcao = 0;
            try
            {
                Console.WriteLine("Ligar Micro-ondas? [s/n]");
                entrada = Console.ReadLine();
                Console.Clear();
            }catch (Exception){
                Console.WriteLine("Informação incorreta, tente novamente");
                entrada = Console.ReadLine();
                Console.Clear();
            }
            try
            {
                do
                {
                    if (entrada.Equals("s"))
                    {
                        Console.WriteLine("||====================================||");
                        Console.WriteLine("||=== Informe uma das opções abaixo ==||");
                        Console.WriteLine("||=== 1 - Aquecimento ================||");
                        Console.WriteLine("||=== 2 - Aquecimento Rápido =========||");
                        Console.WriteLine("||=== 3 - Consulta de Programas ======||");
                        Console.WriteLine("||=== 4 - Executar Programas =========||");
                        Console.WriteLine("||=== 5 - Criar Programas ============||");
                        Console.WriteLine("||=== 6 - Desligar ===================||");
                        Console.WriteLine("||====================================||");
                        opcao = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (opcao)
                        {
                            case 1:
                                ligar.ligarMicro();
                                break;
                            case 2:
                                ligar.rapidoAquecimento();
                                break;
                            case 3:
                                programa.exibirProgramas();
                                if (programa.getComida().Equals("carne"))
                                {
                                    programa.consultarCarne();
                                }
                                else if(programa.getComida().Equals("frango"))
                                {
                                    programa.consultarFrango();
                                }
                                else if (programa.getComida().Equals("peixe"))
                                {
                                    programa.consultarPeixe();
                                }
                                else if (programa.getComida().Equals("feijao"))
                                {
                                    programa.consultarFeijao();
                                }
                                else
                                {
                                    programa.consultarComidaCriada();
                                }
                                break;
                            case 4:
                                programa.exibirProgramas();
                                if (programa.getComida().Equals("carne"))
                                {
                                    programa.esquentarCarne();
                                }
                                else if (programa.getComida().Equals("frango"))
                                {
                                    programa.esquentarFrango();
                                }
                                else if (programa.getComida().Equals("peixe"))
                                {
                                    programa.esquentarPeixe();
                                }
                                else if (programa.getComida().Equals("feijao"))
                                {
                                    programa.esquentarFeijao();
                                }
                                else
                                {
                                    programa.esquentarComidaCriada();
                                }
                                break;
                            case 5:
                                programa.criarPrograma();
                                break;
                            case 6:
                                Console.WriteLine("Desligando programa.......");
                                break;
                        }
                        Console.WriteLine("Deseja utilizar mais o Micro-Ondas? [s/n]");
                        entrada = Console.ReadLine();
                        Console.Clear();
                    }
                } while (entrada != ("n"));
            }
            catch(Exception)
            {
                Console.WriteLine("Informação inválida");
            }
           
        }
    }
}
