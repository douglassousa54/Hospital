using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int m = 0;
            int j = 0;
            int l = 0;
            int k = 0;
            String escolha;

            Paciente[] cadastro1 = new Paciente[10];
            Paciente[] aux1 = new Paciente[1];
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("Cadastrar Pacientes - C");
                Console.WriteLine("Listar Pacientes - L");
                Console.WriteLine("Atender um paciente - A");
                Console.WriteLine("Alterar dados do paciente - D");
                Console.WriteLine("Sair do programa - Q");
                escolha = Console.ReadLine();
                escolha = escolha.ToUpper();

                switch (escolha)
                {
                    case "C":
                        if (i == 10)
                        { Console.WriteLine("Limite de pacientes cadastrados"); }
                        else
                        {
                            Paciente exemplo = new Paciente();
                            exemplo.cadastro();
                            cadastro1[i] = exemplo;
                            i = i+1;
                        }

                        break;

                    case "L":
                        for (l = 0; l < 10; l++)
                        {
                            if (cadastro1[l] == null) {
                                l = 10;
                                Console.WriteLine("fim da lista");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Paciente {0} - idade {1}", cadastro1[l].nome, cadastro1[l].idade);
                            }
                        }
                        break;

                    case "A":


                        for (m = 0; m < 10; m++)
                        {
                            for (j = m+1; j < 10; j++)
                            { if (cadastro1[j] == null)
                                { j = 10;
                                } else if
                                    (cadastro1[m].idade < cadastro1[j].idade)
                                    {

                                        aux1[0] = cadastro1[m];

                                        cadastro1[m] = cadastro1[j];
                                        cadastro1[j] = aux1[0];
                                    }
                                

                            }
                        }
                        Console.WriteLine("Paciente {0} ir para o consultorio", cadastro1[0].nome);
                        Console.ReadKey();
                        cadastro1[0] = null;
                        for (m = 0; m < 10; m++)
                        {
                            j = m + 1;
                            if (j == 10) 
                            { } else
                            {
                                aux1[0] = cadastro1[m];

                                cadastro1[m] = cadastro1[j];
                                cadastro1[j] = aux1[0];
                            }
                                


                            
                        }
                        i = i - 1;

                        break;

                    case "D":
                        for (k = 0; k < 10; k++)

                        {
                            if (cadastro1[k] == null) {
                                Console.WriteLine("fim da lista!");
                                k = 10; ; } else {
                                Console.WriteLine("{0} - Paciente {1} - CPF {2} - Idade {3}", k ,cadastro1[k].nome, cadastro1[k].CPF, cadastro1[k].idade);
                                 }
                        }
                        

                        Console.WriteLine("escolha o numero do paciente que deseja alterar");
                        int mudar = int.Parse(Console.ReadLine());

                        if (mudar > i-1)
                        {
                            Console.WriteLine("Erro! Numero digitado incorreto");
                            Console.ReadKey();
                        }
                        else
                        {
                            Paciente exemplo = new Paciente();
                            exemplo.cadastro();
                            cadastro1[mudar] = exemplo;

                        }
                        break;

                    case "Q":
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("escolha incorreta, tente novamente!");
                        Console.ReadKey();
                        break;
                }
               
                
            } while (escolha != "Q");
        }
    }
}
