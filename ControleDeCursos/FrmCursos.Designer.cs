
namespace ControleDeCursos
{
    partial class FrmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtValorMensalidade = new System.Windows.Forms.TextBox();
            this.lblValorMensalidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dtgCursos = new System.Windows.Forms.DataGridView();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 14);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Curso:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(135, 6);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.BackColor = System.Drawing.Color.LightGray;
            this.txtNomeCurso.Location = new System.Drawing.Point(135, 51);
            this.txtNomeCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(382, 22);
            this.txtNomeCurso.TabIndex = 2;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(14, 54);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(95, 14);
            this.lblNomeCurso.TabIndex = 2;
            this.lblNomeCurso.Text = "Nome do Curso:";
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.BackColor = System.Drawing.Color.LightGray;
            this.txtCargaHoraria.Location = new System.Drawing.Point(401, 195);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(116, 22);
            this.txtCargaHoraria.TabIndex = 5;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(280, 198);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(82, 14);
            this.lblCargaHoraria.TabIndex = 4;
            this.lblCargaHoraria.Text = "Carga Horária:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.Color.LightGray;
            this.txtConteudo.Location = new System.Drawing.Point(135, 94);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(382, 79);
            this.txtConteudo.TabIndex = 3;
            this.txtConteudo.TextChanged += new System.EventHandler(this.txtConteudo_TextChanged);
            // 
            // lblConteudo
            // 
            this.lblConteudo.Location = new System.Drawing.Point(14, 108);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(113, 34);
            this.lblConteudo.TabIndex = 6;
            this.lblConteudo.Text = "Conteúdo Programático:";
            // 
            // txtValorMensalidade
            // 
            this.txtValorMensalidade.BackColor = System.Drawing.Color.LightGray;
            this.txtValorMensalidade.Location = new System.Drawing.Point(135, 195);
            this.txtValorMensalidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorMensalidade.Name = "txtValorMensalidade";
            this.txtValorMensalidade.Size = new System.Drawing.Size(116, 22);
            this.txtValorMensalidade.TabIndex = 4;
            // 
            // lblValorMensalidade
            // 
            this.lblValorMensalidade.AutoSize = true;
            this.lblValorMensalidade.Location = new System.Drawing.Point(14, 198);
            this.lblValorMensalidade.Name = "lblValorMensalidade";
            this.lblValorMensalidade.Size = new System.Drawing.Size(107, 14);
            this.lblValorMensalidade.TabIndex = 8;
            this.lblValorMensalidade.Text = "Valor Mensalidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(31, 14);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 32);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(143, 14);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 32);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(259, 14);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 32);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(371, 14);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 32);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dtgCursos
            // 
            this.dtgCursos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Location = new System.Drawing.Point(14, 312);
            this.dtgCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.Size = new System.Drawing.Size(504, 188);
            this.dtgCursos.TabIndex = 10;
            this.dtgCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCursos_CellClick);
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnListar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Location = new System.Drawing.Point(14, 230);
            this.pnlCRUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(504, 62);
            this.pnlCRUD.TabIndex = 15;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 514);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.dtgCursos);
            this.Controls.Add(this.txtValorMensalidade);
            this.Controls.Add(this.lblValorMensalidade);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.lblCargaHoraria);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURSOS";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtValorMensalidade;
        private System.Windows.Forms.Label lblValorMensalidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dtgCursos;
        private System.Windows.Forms.Panel pnlCRUD;
    }
}