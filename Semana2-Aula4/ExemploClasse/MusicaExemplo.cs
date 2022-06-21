using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.ExemploClasse
{
    public class MusicaExemplo
    {
        public bool Do { get; set; }
        public bool Re { get; set; }
        public bool Mi { get; set; }
        public bool Fa { get; set; }
        public bool Sol { get; set; }
        public bool La { get; set; }
        public bool Si { get; set; }
        public MusicaExemplo()
        {
        }

        public MusicaExemplo(bool notaSiDrop)
        {
            Si = notaSiDrop;
        }
    }


    public class CifraExemplo
    {
        public void TocarNotaSol()
        {
            if (NotaSol(new MusicaExemplo { Si = true, Do = true, Sol = false })){
                Console.WriteLine("Nota sol errada");
            }
        }

        private bool NotaSol(MusicaExemplo? musicaExemplo)
        {
            if (musicaExemplo?.Si == true &&
                musicaExemplo?.Re == true &&
                musicaExemplo?.Sol == true)
            {
                return true;
            }
            else
            {
                return false;
            }

            ///Reduzindo código 
            //return musicaExemplo.Sol == true && 
            //       musicaExemplo.Si == true && 
            //       musicaExemplo.Re == true;
        }

    }

    public class Violao : MusicaExemplo
    {
        public bool Mi1 { get; set; }
        public bool Mi2 { get; set; }
        public static int Frequencia;

        private Violao()
        {
        }


        public Violao(bool dropMi1, bool notaSiDrop) : base(notaSiDrop)
        {
            Mi1 = dropMi1;
        }

        static Violao()
        {
            Frequencia = 73; //
        }


        public bool Afinado()
        {
            Si = false;
            Console.WriteLine($"NOT TRUE -  {!Si}");
            Si = true;
            Console.WriteLine($"NOT TRUE -  {!Si}");


            return Mi1  // igual true
                   && La  // igual true
                   && Re // igual true
                   && Sol == true
                   && !Si // NOT TRUE 
                   && Mi2 == true;  // true // false 
        }

        public bool Afinado(bool dropAfinacao)
        {
            return true;
        }

        public bool Afinado(bool dropAfinacao, bool drop2)
        {
            return true;
        }

        public void Capotraste(int posicaoCase)
        {
            /*Criar as notas*/ 
        }
    }
}
