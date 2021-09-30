using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmCursos : Form
    {
        Curso objCurso = new Curso();

        public FrmCursos()
        {
            InitializeComponent();
            dtgCursos.DataSource = objCurso.ListarCursos();


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.valorMensalidade = Double.Parse(txtValorMensalidade.Text);
            objCurso.CadastrarCurso();
            MessageBox.Show("Registro Cadastrado");
            dtgCursos.DataSource = objCurso.ListarCursos();

            //Limpar o Formulario automaticamente aposs inserir os dados

            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtCargaHoraria.Clear();
            txtCargaHoraria.Clear();

            //Preencher novamente o DataViewGrid para mostrar o conteudo inserido
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void dgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carregar nos txt o valor selecionado no grid
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.valorMensalidade = Double.Parse(txtValorMensalidade.Text);
            objCurso.AlterarCurso();
            MessageBox.Show("Registro alterado com sucesso!");
            dtgCursos.DataSource = objCurso.ListarCursos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.ExcluirCurso();
            MessageBox.Show("Registro excluido com sucesso!");
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
