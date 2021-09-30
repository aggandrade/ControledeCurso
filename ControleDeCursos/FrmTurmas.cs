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
    public partial class FrmTurmas : Form
    {
        Turma objTurma = new Turma();
        Professor objProfessor = new Professor();
        Curso objCurso = new Curso();
        public FrmTurmas()
        {
            InitializeComponent();
            dtgTurma.DataSource = objTurma.ListarTurma();
        }

      
        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            cbProfessor.DataSource = objProfessor.ListarProfessor();
            cbProfessor.ValueMember = "codigo";
            cbProfessor.DisplayMember = "nome";


            cbCurso.DataSource = objCurso.ListarCursos();
            cbCurso.ValueMember = "codigo";
            cbCurso.DisplayMember = "nomeCurso";
        }


        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            objTurma.codigoTurma = int.Parse(txtCodigo.Text);
            objTurma.dataInicio = dtpInicio.Text;
            objTurma.dataTermino = dtpTermino.Text;
            objTurma.horaInicio = txtInicio.Text;            
            objTurma.horaTermino = txtTermino.Text;
            objTurma.codigoCurso = (int)cbCurso.SelectedValue; ;
            objTurma.codigoProfessor = (int)cbProfessor.SelectedValue;
            objTurma.CadastrarTurma();
            MessageBox.Show("Turma Cadastrado");
            objTurma.DataSource = objTurma.ListarTurma();

            //Limpar o Formulario automaticamente aposs inserir os dados
            txtInicio.Clear();
            txtTermino.Clear();
            txtCodigo.Clear();

            //Preencher novamente o DataViewGrid para mostrar o conteudo inserido
            dtgTurma.DataSource = objTurma.ListarTurma();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objTurma.codigoTurma = int.Parse(txtCodigo.Text);
            objTurma.dataInicio = dtpInicio.Text;
            objTurma.dataTermino = dtpTermino.Text;
            objTurma.horaInicio = txtInicio.Text;
            objTurma.horaTermino = txtTermino.Text;
            objTurma.codigoCurso = int.Parse(cbCurso.Text);
            objTurma.codigoProfessor = int.Parse(cbProfessor.Text);
            objTurma.AlterarTurma();
            MessageBox.Show("Registro alterado com sucesso!");
            dtgTurma.DataSource = objTurma.ListarTurma();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objTurma.codigoTurma = int.Parse(txtCodigo.Text);
            objTurma.ExcluirTurma();
            MessageBox.Show("Registro excluido com sucesso!");
            dtgTurma.DataSource = objTurma.ListarTurma();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void dtgTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpInicio.Text = "21/01/2021";
            dtpTermino.Text = "21/01/2021";
            txtInicio.Text = dtgTurma.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTermino.Text = dtgTurma.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbCurso.Text = dtgTurma.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbProfessor.Text = dtgTurma.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
