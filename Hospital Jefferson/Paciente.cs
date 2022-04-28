using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Jefferson
{
    class Paciente
    {
        int idade;
        string nome;
        string CPF;

        public void cadastro ()
        {
            Console.WriteLine("Digite o nome do paciente");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do paciente");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite a idade do paciente");
            idade = int.Parse(Console.ReadLine());
        }

        }

    
}
