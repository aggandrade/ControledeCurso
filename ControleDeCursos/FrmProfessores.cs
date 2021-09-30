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
    public partial class FrmProfessores : Form
    {
        Professor objProfessor = new Professor();
        public FrmProfessores()
        {
            InitializeComponent();
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objProfessor.nomeProfessor = txtNome.Text;
            objProfessor.telefoneProfessor = txtTelefone.Text;
            objProfessor.valorHoraAula = Double.Parse(txtValorHoraAula.Text);
            objProfessor.CadastrarProfessor();
            MessageBox.Show("Professor Cadastrado");
            objProfessor.DataSource = objProfessor.ListarProfessor();

            //Limpar o Formulario automaticamente aposs inserir os dados
            txtNome.Clear();
            txtTelefone.Clear();
            txtValorHoraAula.Clear();

            //Preencher novamente o DataViewGrid para mostrar o conteudo inserido
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtCodigo.Text);
            objProfessor.nomeProfessor = txtNome.Text;
            objProfessor.telefoneProfessor = txtTelefone.Text;
            objProfessor.valorHoraAula = Double.Parse(txtValorHoraAula.Text);
            objProfessor.AlterarProfessor();
            MessageBox.Show("Registro alterado com sucesso!");
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtCodigo.Text);
            objProfessor.ExcluirProfessor();
            MessageBox.Show("Registro excluido com sucesso!");
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void dtgProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carregar nos txt o valor selecionado no grid
            txtCodigo.Text = dtgProfessor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgProfessor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dtgProfessor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorHoraAula.Text = dtgProfessor.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
