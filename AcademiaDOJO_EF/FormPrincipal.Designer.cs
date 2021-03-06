
namespace AcademiaDOJO_EF
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.lblAluno = new System.Windows.Forms.Label();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnAlterarProfessor = new System.Windows.Forms.Button();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnNovoProfessor = new System.Windows.Forms.Button();
            this.dgvModalidade = new System.Windows.Forms.DataGridView();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.btnNovaModalidade = new System.Windows.Forms.Button();
            this.btnExcluirModalidade = new System.Windows.Forms.Button();
            this.btnAlterarModalidade = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezesSemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.AllowUserToAddRows = false;
            this.dgvProfessor.AllowUserToDeleteRows = false;
            this.dgvProfessor.AutoGenerateColumns = false;
            this.dgvProfessor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn3,
            this.telefoneDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.salarioHoraDataGridViewTextBoxColumn});
            this.dgvProfessor.DataSource = this.professorBindingSource;
            this.dgvProfessor.Location = new System.Drawing.Point(65, 89);
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.ReadOnly = true;
            this.dgvProfessor.RowHeadersWidth = 51;
            this.dgvProfessor.RowTemplate.Height = 24;
            this.dgvProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessor.Size = new System.Drawing.Size(680, 297);
            this.dgvProfessor.TabIndex = 0;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(61, 63);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(87, 23);
            this.lblProfessor.TabIndex = 2;
            this.lblProfessor.Text = "Professor";
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AutoGenerateColumns = false;
            this.dgvAluno.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn2,
            this.cPFDataGridViewTextBoxColumn1,
            this.telefoneDataGridViewTextBoxColumn1,
            this.Modalidade});
            this.dgvAluno.DataSource = this.alunoBindingSource1;
            this.dgvAluno.Location = new System.Drawing.Point(411, 431);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.RowHeadersWidth = 51;
            this.dgvAluno.RowTemplate.Height = 24;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(579, 297);
            this.dgvAluno.TabIndex = 4;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblAluno.Location = new System.Drawing.Point(407, 405);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(61, 23);
            this.lblAluno.TabIndex = 5;
            this.lblAluno.Text = "Aluno";
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.Location = new System.Drawing.Point(411, 734);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnNovoAluno.TabIndex = 6;
            this.btnNovoAluno.Text = "Novo...";
            this.btnNovoAluno.UseVisualStyleBackColor = true;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(573, 734);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 7;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.Location = new System.Drawing.Point(492, 734);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 9;
            this.btnAlterarAluno.Text = "Alterar...";
            this.btnAlterarAluno.UseVisualStyleBackColor = true;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnAlterarProfessor
            // 
            this.btnAlterarProfessor.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarProfessor.Location = new System.Drawing.Point(146, 392);
            this.btnAlterarProfessor.Name = "btnAlterarProfessor";
            this.btnAlterarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarProfessor.TabIndex = 17;
            this.btnAlterarProfessor.Text = "Alterar...";
            this.btnAlterarProfessor.UseVisualStyleBackColor = true;
            this.btnAlterarProfessor.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.Location = new System.Drawing.Point(227, 392);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 15;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = true;
            this.btnExcluirProfessor.Click += new System.EventHandler(this.btnExcluirProfessor_Click);
            // 
            // btnNovoProfessor
            // 
            this.btnNovoProfessor.Location = new System.Drawing.Point(65, 392);
            this.btnNovoProfessor.Name = "btnNovoProfessor";
            this.btnNovoProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProfessor.TabIndex = 14;
            this.btnNovoProfessor.Text = "Novo...";
            this.btnNovoProfessor.UseVisualStyleBackColor = true;
            this.btnNovoProfessor.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // dgvModalidade
            // 
            this.dgvModalidade.AllowUserToAddRows = false;
            this.dgvModalidade.AllowUserToDeleteRows = false;
            this.dgvModalidade.AutoGenerateColumns = false;
            this.dgvModalidade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.vezesSemanaDataGridViewTextBoxColumn,
            this.precoHoraDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn});
            this.dgvModalidade.DataSource = this.modalidadeBindingSource;
            this.dgvModalidade.GridColor = System.Drawing.Color.LightGray;
            this.dgvModalidade.Location = new System.Drawing.Point(753, 89);
            this.dgvModalidade.Name = "dgvModalidade";
            this.dgvModalidade.ReadOnly = true;
            this.dgvModalidade.RowHeadersWidth = 51;
            this.dgvModalidade.RowTemplate.Height = 24;
            this.dgvModalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidade.Size = new System.Drawing.Size(555, 297);
            this.dgvModalidade.TabIndex = 1;
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.lblModalidade.Location = new System.Drawing.Point(1214, 63);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(109, 23);
            this.lblModalidade.TabIndex = 3;
            this.lblModalidade.Text = "Modalidade";
            // 
            // btnNovaModalidade
            // 
            this.btnNovaModalidade.Location = new System.Drawing.Point(754, 392);
            this.btnNovaModalidade.Name = "btnNovaModalidade";
            this.btnNovaModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnNovaModalidade.TabIndex = 10;
            this.btnNovaModalidade.Text = "Novo...";
            this.btnNovaModalidade.UseVisualStyleBackColor = true;
            this.btnNovaModalidade.Click += new System.EventHandler(this.btnNovaModalidade_Click);
            // 
            // btnExcluirModalidade
            // 
            this.btnExcluirModalidade.Location = new System.Drawing.Point(916, 392);
            this.btnExcluirModalidade.Name = "btnExcluirModalidade";
            this.btnExcluirModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirModalidade.TabIndex = 11;
            this.btnExcluirModalidade.Text = "Excluir";
            this.btnExcluirModalidade.UseVisualStyleBackColor = true;
            this.btnExcluirModalidade.Click += new System.EventHandler(this.btnExcluirModalidade_Click);
            // 
            // btnAlterarModalidade
            // 
            this.btnAlterarModalidade.Location = new System.Drawing.Point(835, 392);
            this.btnAlterarModalidade.Name = "btnAlterarModalidade";
            this.btnAlterarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarModalidade.TabIndex = 13;
            this.btnAlterarModalidade.Text = "Alterar...";
            this.btnAlterarModalidade.UseVisualStyleBackColor = true;
            this.btnAlterarModalidade.Click += new System.EventHandler(this.btnNovaModalidade_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Modalidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modalidade";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "Academia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AcademiaDOJO_EF.Properties.Resources.academia__1_;
            this.pictureBox1.Location = new System.Drawing.Point(790, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome - Aluno";
            this.nomeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            this.nomeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn2.Width = 150;
            // 
            // cPFDataGridViewTextBoxColumn1
            // 
            this.cPFDataGridViewTextBoxColumn1.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn1.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn1.Name = "cPFDataGridViewTextBoxColumn1";
            this.cPFDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPFDataGridViewTextBoxColumn1.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn1
            // 
            this.telefoneDataGridViewTextBoxColumn1.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn1.Name = "telefoneDataGridViewTextBoxColumn1";
            this.telefoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.telefoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Modalidade
            // 
            this.Modalidade.DataPropertyName = "Modalidade";
            this.Modalidade.HeaderText = "Modalidade";
            this.Modalidade.MinimumWidth = 6;
            this.Modalidade.Name = "Modalidade";
            this.Modalidade.ReadOnly = true;
            this.Modalidade.Width = 125;
            // 
            // alunoBindingSource1
            // 
            this.alunoBindingSource1.DataSource = typeof(AcademiaDOJO_EF.Dominio.Aluno);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vezesSemanaDataGridViewTextBoxColumn
            // 
            this.vezesSemanaDataGridViewTextBoxColumn.DataPropertyName = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.HeaderText = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vezesSemanaDataGridViewTextBoxColumn.Name = "vezesSemanaDataGridViewTextBoxColumn";
            this.vezesSemanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vezesSemanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoHoraDataGridViewTextBoxColumn
            // 
            this.precoHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.HeaderText = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoHoraDataGridViewTextBoxColumn.Name = "precoHoraDataGridViewTextBoxColumn";
            this.precoHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.ReadOnly = true;
            this.professorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.professorDataGridViewTextBoxColumn.Width = 125;
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(AcademiaDOJO_EF.Dominio.Modalidade);
            // 
            // nomeDataGridViewTextBoxColumn3
            // 
            this.nomeDataGridViewTextBoxColumn3.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn3.Name = "nomeDataGridViewTextBoxColumn3";
            this.nomeDataGridViewTextBoxColumn3.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn3.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarioHoraDataGridViewTextBoxColumn
            // 
            this.salarioHoraDataGridViewTextBoxColumn.DataPropertyName = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.HeaderText = "SalarioHora";
            this.salarioHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarioHoraDataGridViewTextBoxColumn.Name = "salarioHoraDataGridViewTextBoxColumn";
            this.salarioHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(AcademiaDOJO_EF.Dominio.Professor);
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1375, 766);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarProfessor);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.btnNovoProfessor);
            this.Controls.Add(this.btnAlterarModalidade);
            this.Controls.Add(this.btnExcluirModalidade);
            this.Controls.Add(this.btnNovaModalidade);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.dgvModalidade);
            this.Controls.Add(this.dgvProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.BindingSource alunoBindingSource1;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnAlterarProfessor;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnNovoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvModalidade;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnNovaModalidade;
        private System.Windows.Forms.Button btnExcluirModalidade;
        private System.Windows.Forms.Button btnAlterarModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezesSemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

