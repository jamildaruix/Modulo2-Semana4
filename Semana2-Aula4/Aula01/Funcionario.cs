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
        public Decimal Salario { get; private set; }

        public Funcionario()
        {
            Salario = 1500M;
        }

        public void SalvarNomeFuncionario()
        {
            Console.WriteLine($"Salvo o nome: {Nome}");
            Console.WriteLine("Salvo o nome: " + Nome);
            Console.WriteLine(string.Format("Salvo o nome: {0}", Nome));
        }

        public void ReajusteConvensaoColetiva(int percentual)
        {
            Salario += Salario * (Convert.ToDecimal(percentual) / 100);
            Salario++;
        }

        #region SOBRECARGA

        /// <summary>
        /// Retorno da string com os campos Primeiro Nome, Segundo Nome
        /// </summary>
        /// <param name="primeiroNome"></param>
        /// <param name="segundoNome"></param>
        /// <returns>Nome: SEU NOME AQUI</returns>
        public string DadosFuncionario(string primeiroNome, string segundoNome)
        {
            return $"Nome: {primeiroNome} {segundoNome}";
        }

        /// <summary>
        /// Retorno da string com os campos Primeiro Nome, Segundo Nome, DataNascimento
        /// </summary>
        /// <param name="primeiroNome"></param>
        /// <param name="segundoNome"></param>
        /// <param name="dataNascimento"></param>
        /// <returns>Nome: SEU NOME AQUI | Data Nascimento SUA DATA</returns>
        public string DadosFuncionario(string primeiroNome, string segundoNome, DateTime dataNascimento)
        {
            //return $"Nome: {primeiroNome} {segundoNome}| Data Nascimento {dataNascimento}";

            return  $"{DadosFuncionario(primeiroNome, segundoNome)}| Data Nascimento {dataNascimento}";
        }

        #endregion
    }
}
