using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Turma
    {
        public int codigoTurma, codigoProfessor, codigoCurso;
        public string nomeCurso, nomeProfessor, dataInicio, dataTermino, horaInicio, horaTermino;
        string tabela = "tbl_turma";

        Conexao obj = new Conexao();

        public DataTable DataSource { get; internal set; }

        public void CadastrarTurma()
        {
            string inserir = $"insert into {tabela} values(null,'{dataInicio}','{dataTermino}','{horaInicio}','{horaTermino}','{codigoCurso}','{codigoProfessor}');";
            obj.ExecutarComando(inserir);

        }
        public void AlterarTurma()
        {
            string alterar = $@"update {tabela} set idCurso= '{codigoCurso}',
            idProfessor= '{codigoProfessor}',
            horaInicio='{horaInicio}',
            horaTermino='{horaTermino}',
            dataInicio='{dataInicio}',
            dataTermino='{dataTermino}' where codigo='{codigoTurma}';";
            obj.ExecutarComando(alterar);
        }
        public void ExcluirTurma()
        {
            string exluir = $"delete from {tabela} where codigo='{codigoTurma}';";
            obj.ExecutarComando(exluir);

        }
        public DataTable ListarTurma()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by codigo;";
            return obj.ExecutarConsulta(sql);
        }

    }
}
