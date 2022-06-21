namespace Semana2_Aula4.ExemploClasse
{
    public class Pai
    {
        public virtual int CalcularCodigo()
        {
            return 15;
        }
    }

    public class Filho : Pai
    {
        public void MetodoHeranca()
        {
            this.CalcularCodigo();
            base.CalcularCodigo();
            CalcularCodigo();
        }
    }

}
