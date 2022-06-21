using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.Aula01
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public void SalvarNomeFuncionario()
        {
            Console.WriteLine($"Salvo o nome: {Nome}");
            Console.WriteLine("Salvo o nome: " + Nome);
            Console.WriteLine(string.Format("Salvo o nome: {0}", Nome));
        }
    }
}
