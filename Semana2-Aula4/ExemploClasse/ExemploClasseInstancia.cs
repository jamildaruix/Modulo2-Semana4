using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Aula4.ExemploClasse
{
    public class ExemploClasseInstancia
    {
        const int ID = 10;

        public void CinquetaCentavosDeZoom()
        {
            ExemploEstatico.CinquetaCentavosDeZoom();

            Console.WriteLine($"Id {ID}");
            Console.WriteLine("CinquetaCentavosDeZoom");


            CifraExemplo cifraExemplo = new CifraExemplo();
            cifraExemplo.TocarNotaSol();

        }
    }
}
