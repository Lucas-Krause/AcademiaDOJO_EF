
namespace AcademiaDOJO_EF
{
    partial class FormModalidade
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelarModalidade = new System.Windows.Forms.Button();
            this.btnSalvarModalidade = new System.Windows.Forms.Button();
            this.txtPrecoHoraModalidade = new System.Windows.Forms.TextBox();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxVezesSemana = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarModalidade
            // 
            this.btnCancelarModalidade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarModalidade.Location = new System.Drawing.Point(113, 140);
            this.btnCancelarModalidade.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarModalidade.Name = "btnCancelarModalidade";
            this.btnCancelarModalidade.Size = new System.Drawing.Size(64, 19);
            this.btnCancelarModalidade.TabIndex = 5;
            this.btnCancelarModalidade.Text = "Cancelar";
            this.btnCancelarModalidade.UseVisualStyleBackColor = true;
            // 
            // btnSalvarModalidade
            // 
            this.btnSalvarModalidade.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarModalidade.Location = new System.Drawing.Point(52, 140);
            this.btnSalvarModalidade.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarModalidade.Name = "btnSalvarModalidade";
            this.btnSalvarModalidade.Size = new System.Drawing.Size(56, 19);
            this.btnSalvarModalidade.TabIndex = 4;
            this.btnSalvarModalidade.Text = "Salvar";
            this.btnSalvarModalidade.UseVisualStyleBackColor = true;
            // 
            // txtPrecoHoraModalidade
            // 
            this.txtPrecoHoraModalidade.Location = new System.Drawing.Point(96, 61);
            this.txtPrecoHoraModalidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoHoraModalidade.Name = "txtPrecoHoraModalidade";
            this.txtPrecoHoraModalidade.Size = new System.Drawing.Size(81, 20);
            this.txtPrecoHoraModalidade.TabIndex = 2;
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(5, 24);
            this.txtNomeModalidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(172, 20);
            this.txtNomeModalidade.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vezes Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(AcademiaDOJO_EF.Dominio.Modalidade);
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.DataSource = this.professorBindingSource;
            this.cbxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(5, 98);
            this.cbxProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(103, 21);
            this.cbxProfessor.TabIndex = 3;
            this.cbxProfessor.SelectedIndexChanged += new System.EventHandler(this.cbxProfessor_SelectedIndexChanged);
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(AcademiaDOJO_EF.Dominio.Professor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Professor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 2);
            this.panel1.TabIndex = 21;
            // 
            // cbxVezesSemana
            // 
            this.cbxVezesSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVezesSemana.FormattingEnabled = true;
            this.cbxVezesSemana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxVezesSemana.Location = new System.Drawing.Point(5, 61);
            this.cbxVezesSemana.Margin = new System.Windows.Forms.Padding(2);
            this.cbxVezesSemana.Name = "cbxVezesSemana";
            this.cbxVezesSemana.Size = new System.Drawing.Size(75, 21);
            this.cbxVezesSemana.TabIndex = 1;
            // 
            // FormModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 168);
            this.ControlBox = false;
            this.Controls.Add(this.cbxVezesSemana);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.btnCancelarModalidade);
            this.Controls.Add(this.btnSalvarModalidade);
            this.Controls.Add(this.txtPrecoHoraModalidade);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModalidade";
            this.Load += new System.EventHandler(this.FormModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.Button btnCancelarModalidade;
        private System.Windows.Forms.Button btnSalvarModalidade;
        private System.Windows.Forms.TextBox txtPrecoHoraModalidade;
        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxVezesSemana;
    }
}