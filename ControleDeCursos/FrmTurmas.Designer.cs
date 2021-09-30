
namespace ControleDeCursos
{
    partial class FrmTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurmas));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dtgTurma = new System.Windows.Forms.DataGridView();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtTermino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(135, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Início:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(135, 43);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(116, 22);
            this.dtpInicio.TabIndex = 15;
            // 
            // dtpTermino
            // 
            this.dtpTermino.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTermino.Location = new System.Drawing.Point(405, 43);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(116, 22);
            this.dtpTermino.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora de Término:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Location = new System.Drawing.Point(17, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 61);
            this.panel1.TabIndex = 21;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(31, 14);
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
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
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
            // dtgTurma
            // 
            this.dtgTurma.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurma.Location = new System.Drawing.Point(17, 246);
            this.dtgTurma.Name = "dtgTurma";
            this.dtgTurma.Size = new System.Drawing.Size(504, 162);
            this.dtgTurma.TabIndex = 22;
            this.dtgTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTurma_CellClick);
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.Color.LightGray;
            this.txtInicio.Location = new System.Drawing.Point(135, 84);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(116, 22);
            this.txtInicio.TabIndex = 23;
            // 
            // txtTermino
            // 
            this.txtTermino.BackColor = System.Drawing.Color.LightGray;
            this.txtTermino.Location = new System.Drawing.Point(405, 84);
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(116, 22);
            this.txtTermino.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso:";
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.Color.LightGray;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(405, 5);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(116, 22);
            this.cbCurso.TabIndex = 26;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // cbProfessor
            // 
            this.cbProfessor.BackColor = System.Drawing.Color.LightGray;
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Location = new System.Drawing.Point(135, 123);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(116, 22);
            this.cbProfessor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Professor(a):";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 424);
            this.Controls.Add(this.cbProfessor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTermino);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.dtgTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTermino);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TURMAS";
            this.Load += new System.EventHandler(this.FrmTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dtgTurma;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtTermino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label label7;
    }
}