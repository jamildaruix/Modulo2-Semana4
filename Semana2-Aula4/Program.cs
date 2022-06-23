using Semana2_Aula4.Aula01;
using Semana2_Aula4.ExemploClasse;

namespace Semana2_Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            //Preencher o ID do Funcionário
            //Colocar a Data de Nascimento 
            funcionario.Nome = "Nome de vocês aqui";
            funcionario.SalvarNomeFuncionario();
            //Refatorar ou criar uma nova sobrecarga
            //Colocar o console.writeline para impressão da tela
            funcionario.DadosFuncionario("seu nome", "seu sobrenome");
            funcionario.DadosFuncionario("seu nome", "seu sobrenome", DateTime.Now.AddYears(-37));

            Console.WriteLine($"Salario sem Reajuste {funcionario.Salario}");
            Console.WriteLine($"Aplicando Reajuste Salario de 50%");
            funcionario.ReajusteConvensaoColetiva(50);
            Console.WriteLine($"Salario com Reajuste {funcionario.Salario}");

            CentroDeCusto centroDeCusto = new CentroDeCusto(1, "TESTE", DateTime.Now, 10M, 2022);

            Departamento departamento = new Departamento(centroDeCusto);
            departamento.Id = 100;
            departamento.DesricaoDepartamento = "Dev In House";
            departamento.CentroDeCusto = new Random(50).Next(5000);
            departamento.FuncionarioNoDepartamento = funcionario;
            departamento.InserirFuncionarNoDepartamento();

            ///Efetuar Pagamento Sucesso e alterando o valor do TipoFuncioanrio (ENUM)
            Pagamento pagamentoEfetuadoSucesso = new Pagamento(1500,100, EnumEstado.SP, 
                                                EnumTipoFuncionario.PJ, 
                                                DateTime.Now.AddDays(15));

            /*...*/

            pagamentoEfetuadoSucesso.TipoFuncionario = EnumTipoFuncionario.Autonomo;
            pagamentoEfetuadoSucesso.EfetuarCalculo();


            ///Simular o Erro do pagamento
            Pagamento pagamentoEfetuadoErro = new Pagamento(3000, 5900, EnumEstado.MG,
                                                EnumTipoFuncionario.PJ,
                                                DateTime.Now);

            pagamentoEfetuadoErro.TipoFuncionario = EnumTipoFuncionario.PF;
            pagamentoEfetuadoErro.EfetuarCalculo();


            //var violao = new Violao(true, false);
            //violao.Afinado();
            //violao.Afinado(dropAfinacao: true, drop2: true);

            //ExemploEstatico.CinquetaCentavosDeZoom();

            //ExemploClasseInstancia exemploClasse = new ExemploClasseInstancia();
            //exemploClasse.CinquetaCentavosDeZoom();
        }
    }


}