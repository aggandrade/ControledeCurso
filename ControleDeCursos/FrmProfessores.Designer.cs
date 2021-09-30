
namespace ControleDeCursos
{
    partial class FrmProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessores));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorHoraAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgProfessor = new System.Windows.Forms.DataGridView();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightGray;
            this.txtNome.Location = new System.Drawing.Point(135, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(382, 22);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Completo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(135, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do Professor:";
            // 
            // txtValorHoraAula
            // 
            this.txtValorHoraAula.BackColor = System.Drawing.Color.LightGray;
            this.txtValorHoraAula.Location = new System.Drawing.Point(135, 85);
            this.txtValorHoraAula.Name = "txtValorHoraAula";
            this.txtValorHoraAula.Size = new System.Drawing.Size(116, 22);
            this.txtValorHoraAula.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor da hora/aula:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(14, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 61);
            this.panel1.TabIndex = 22;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(31, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 32);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(143, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 32);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(371, 14);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 32);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(259, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 32);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dtgProfessor
            // 
            this.dtgProfessor.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfessor.Location = new System.Drawing.Point(14, 200);
            this.dtgProfessor.Name = "dtgProfessor";
            this.dtgProfessor.Size = new System.Drawing.Size(504, 162);
            this.dtgProfessor.TabIndex = 23;
            this.dtgProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfessor_CellClick);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.LightGray;
            this.txtTelefone.Location = new System.Drawing.Point(402, 85);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 22);
            this.txtTelefone.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefone:";
            // 
            // FrmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 380);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgProfessor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValorHoraAula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFESSORES";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorHoraAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgProfessor;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label4;
    }
}