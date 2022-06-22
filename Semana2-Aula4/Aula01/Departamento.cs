using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.Aula01
{
    public class Departamento
    {
        public int Id { get; set; }
        public string DesricaoDepartamento { get; set; }
        public int CentroDeCusto { get; set; }
        public Funcionario FuncionarioNoDepartamento { get; set; }
        public CentroDeCusto CentroDeCustoDoDepartamento { get; set; }

        private Departamento()
        {
        }

        public Departamento(CentroDeCusto centroDeCusto)
        {
            if (centroDeCusto == null)
            {
                throw new Exception("Erro no Centro de Custo");
            }

            CentroDeCustoDoDepartamento = centroDeCusto;
        }

        public void InserirFuncionarNoDepartamento()
        {
            Console.WriteLine($"Desricao do Departamento {DesricaoDepartamento}");
            Console.WriteLine($"Centro de Custo {CentroDeCusto}");
            Console.WriteLine($@"Id do Funcionario {FuncionarioNoDepartamento.Id};
                                 Nome do Funcionario {FuncionarioNoDepartamento.Nome};
                                 Data de Nascimento {FuncionarioNoDepartamento.DataNascimento}");

            ///Data de Nascimento nos seguintes formatos
            /// DD/MM/YYYY
            /// d/MMM/yy
        }

    }
}
