using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;
        string tabela = "tbl_curso";

        Conexao obj = new Conexao();
        
        public void CadastrarCurso()
        {
            string inserir = $"insert into {tabela} values(null,'{nomeCurso}','{conteudoProgramatico}','{valorMensalidade}','{cargaHoraria}');";
            obj.ExecutarComando(inserir);
        
        }

        public void AlterarCurso()
        {
            string alterar = $@"update {tabela} set nomeCurso= '{nomeCurso}',
            conteudo='{conteudoProgramatico}',
            valorMensalidade='{valorMensalidade}',
            cargaHoraria='{cargaHoraria}' where codigo='{codigoCurso}';";
            obj.ExecutarComando(alterar);

        }

        public void ExcluirCurso()
        {
            string exluir = $"delete from {tabela} where codigo='{codigoCurso}';";
            obj.ExecutarComando(exluir);


        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by codigo;";
            return obj.ExecutarConsulta(sql);
        }
    }
}
