﻿using Semana2_Aula4.Aula01;
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

            Departamento departamento = new Departamento();
            departamento.Id = 100;
            departamento.DesricaoDepartamento = "Dev In House";
            departamento.CentroDeCusto = new Random(50).Next(5000);
            departamento.FuncionarioNoDepartamento = funcionario;

            departamento.InserirFuncionarNoDepartamento();


            var violao = new Violao(true, false);
            violao.Afinado();
            violao.Afinado(dropAfinacao: true, drop2: true);

            //ExemploEstatico.CinquetaCentavosDeZoom();

            //ExemploClasseInstancia exemploClasse = new ExemploClasseInstancia();
            //exemploClasse.CinquetaCentavosDeZoom();
        }
    }


}