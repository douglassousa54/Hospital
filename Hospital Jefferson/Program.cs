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
            Paciente[] cadastro1 = new Paciente[10];

            Console.WriteLine("MENU");
            Console.WriteLine("Cadastrar Pacientes - C");
            Console.WriteLine("Listar Pacientes - L");
            Console.WriteLine("Atender um paciente - A");
            Console.WriteLine("Alterar dados do paciente - D");
            Console.WriteLine("Sair do programa - Q");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "C":
                    
                    Paciente exemplo = new Paciente();
                    exemplo.cadastro();
                    cadastro1[i] = exemplo;

                    break;

                case "L":

                    break;

                case "A":

                    break;

                case "D":

                    break;

                case "Q":

                    break;
                
            }
        }
    }
}
