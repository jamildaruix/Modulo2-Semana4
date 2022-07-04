using Semana2_Aula4.Aula01;
using Semana2_Aula4.ExemploClasse;

namespace Semana2_Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "OLÁ MUNDO !";

            try
            {
                int valorMensagem = Convert.ToInt32(mensagem);
            }
            catch (AccessViolationException ex)
            {
                throw;
            }
            catch
            {
                throw new ("IXI NÃO FUNCIONOU !!! ┏(-_-)┓");
            }


        }
    }


}