using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.Aula01
{
    public class CentroDeCusto : LogDeErrosNoSistema
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal VerbaLiberada { get; set; }
        public int AnoVerbaLiberada { get; set; }

        public CentroDeCusto(int id, string descricao,
                            DateTime dataCriacao,
                            decimal verbaLiberada,
                            int anoVerbaLiberada)
        {
            Id = id;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            VerbaLiberada = verbaLiberada;
            AnoVerbaLiberada = anoVerbaLiberada;
        }

        public void AlterarId(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Método de sobreescrita da classe <see cref="System.Object"/>
        /// do C# 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);

            //return $@"{base.ToString()} | 
            //          Sobreescrita da classe CentroDeCusto {Id}|{Descricao}|{VerbaLiberada}";
        }

        /// <summary>
        /// Método de sobreescrita para Logar informação
        /// </summary>
        /// <returns></returns>
        public override string Logar()
        {
            /*NESTE MOMENTO SERÁ ARMAZENADO EM UM ARQUIVO .TXT PARA LOG*/
            var defaultInformacao = base.Logar();

            Console.WriteLine($@"{defaultInformacao} | Sobreescrita da classe CentroDeCusto {Id}|{Descricao}|{VerbaLiberada}");
            return $@"{defaultInformacao} | Sobreescrita da classe CentroDeCusto {Id}|{Descricao}|{VerbaLiberada}";
        }
    }

    /// <summary>
    /// Classe abstract para criar um método de sobreescrita chamado LOGAR();
    /// </summary>
    public abstract class LogDeErrosNoSistema
    {
        public virtual string Logar()
        {
            return $"{DateTime.Now} - LogarInformacao";
        }
    }
}
