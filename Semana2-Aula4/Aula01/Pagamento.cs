using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.Aula01
{
    public class Pagamento
    {
        #region PROPRIEDADES PUBLICAS VISIVEIS A OUTROS CLASSES

        /// <summary>
        /// Privado somente a classe altera o conteudo!
        /// </summary>
        public decimal Valor { get; private set; }
        public int IdFuncionario { get; private set; }
        public EnumEstado Estado { get; private set; }

        /// <summary>
        /// Propriedade pode ser altearada fora da calsse Pagamento
        /// </summary>
        public EnumTipoFuncionario TipoFuncionario { get; set; }

        #endregion

        #region PROPRIEDADES PRIVADAS PARA ENCAPSULAMENTO DA CLASSE PAGAMENTO

        private decimal CalcularPercentaulDeDesconto { get; set; }
        private decimal SaldoInicial { get; set; }
        private decimal SaldoComDesconto { get; set; }
        private DateTime DataPagamento { get; set; }

        #endregion

        public Pagamento(decimal valor, int idFuncionario, 
                        EnumEstado estado, 
                        EnumTipoFuncionario tipoFuncionario,
                        DateTime dataPagamento)
        {
            Valor = valor;
            IdFuncionario = idFuncionario;
            Estado = estado;
            TipoFuncionario = tipoFuncionario;
            DataPagamento = dataPagamento;
        }

    
        #region MÉTODO QUE VAI EXECUTAR OS MÉTODOS PRIVADOS DA CLASSE PAGAMENTO
        internal void EfetuarCalculo()
        {
            /*Data Pamento for menor que o dia 15 do mês é efetuado pagamento*/
            /*Data Pamento for maior que o dia 15 do mês é não efetuado pagamento*/
        }

        #endregion

        #region ENCAPSULAMENTO DOS MÉTODOS DA CLASSE PAGAMENTO

        private void SimularConsultaBancoDadosParaSaldoInicial()
        {
            /*Buscando a informação em um banco de dados*/
            SaldoInicial = 1500m;
        }

        private void SimularConsultaBancoDadosParaSaldoComDesconto()
        {
            /*Buscando a informação em um banco de dados*/
            SaldoComDesconto = 10M;
        }

        #endregion
    }
}
