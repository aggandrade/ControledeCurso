using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Professor
    {
        public int codigoProfessor;
        public string nomeProfessor, telefoneProfessor;
        public double valorHoraAula;
        string tabela = "tbl_professor";

        Conexao obj = new Conexao();

        public DataTable DataSource { get; internal set; }

        public void CadastrarProfessor()
        {
            string inserir = $"insert into {tabela} values(null,'{nomeProfessor}','{telefoneProfessor}','{valorHoraAula}');";
            obj.ExecutarComando(inserir);

        }
        public void AlterarProfessor()
        {
            string alterar = $@"update {tabela} set nome= '{nomeProfessor}', telefone='{telefoneProfessor}', valorHoraAula='{valorHoraAula}'
            where codigo='{codigoProfessor}';";
            obj.ExecutarComando(alterar);

        }

        public void ExcluirProfessor()
        {
            string exluir = $"delete from {tabela} where codigo='{codigoProfessor}';";
            obj.ExecutarComando(exluir);


        }

        public DataTable ListarProfessor()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by codigo;";
            return obj.ExecutarConsulta(sql);
        }

    }
}
