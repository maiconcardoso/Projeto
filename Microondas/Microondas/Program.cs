using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class Program
    {
        static void Main(string[] args)
        {
            LigarMicroOndas ligar = new LigarMicroOndas();
            Programas programa = new Programas();
            ConsultarProgramas consulta = new ConsultarProgramas();
            CriarProgramaAquecimento criar = new CriarProgramaAquecimento();
            string entrada;
            int opcao = 0;
            Console.WriteLine("Ligar Micro-ondas? [s/n]");
            entrada = Console.ReadLine();
            Console.Clear();
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
                                consulta.exibirProgramasConsulta();
                                consulta.consultarCarne();
                                consulta.consultarFrango();
                                consulta.consultarPeixe();
                                consulta.consultarFeijao();
                                break;
                            case 4:
                                programa.exibirProgramas();
                                programa.esquentarCarne();
                                programa.esquentarFrango();
                                programa.esquentarPeixe();
                                programa.esquentarFeijao();
                                break;
                            case 5:
                                criar.criarPrograma();
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
