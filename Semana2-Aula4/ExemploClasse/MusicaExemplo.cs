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
}
