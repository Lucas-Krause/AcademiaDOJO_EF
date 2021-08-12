
namespace AcademiaDOJO_EF
{
    partial class FormProfessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.mskCPFProfessor = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefoneProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioProfessor = new System.Windows.Forms.TextBox();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.btnCancelarProfessor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salário";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(11, 25);
            this.txtNomeProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(193, 20);
            this.txtNomeProfessor.TabIndex = 0;
            // 
            // mskCPFProfessor
            // 
            this.mskCPFProfessor.Location = new System.Drawing.Point(11, 62);
            this.mskCPFProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.mskCPFProfessor.Mask = "000,000,000-00";
            this.mskCPFProfessor.Name = "mskCPFProfessor";
            this.mskCPFProfessor.Size = new System.Drawing.Size(93, 20);
            this.mskCPFProfessor.TabIndex = 1;
            // 
            // mskTelefoneProfessor
            // 
            this.mskTelefoneProfessor.Location = new System.Drawing.Point(111, 62);
            this.mskTelefoneProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.mskTelefoneProfessor.Mask = "(00)00000-0000";
            this.mskTelefoneProfessor.Name = "mskTelefoneProfessor";
            this.mskTelefoneProfessor.Size = new System.Drawing.Size(93, 20);
            this.mskTelefoneProfessor.TabIndex = 2;
            // 
            // txtSalarioProfessor
            // 
            this.txtSalarioProfessor.Location = new System.Drawing.Point(111, 99);
            this.txtSalarioProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioProfessor.Name = "txtSalarioProfessor";
            this.txtSalarioProfessor.Size = new System.Drawing.Size(93, 20);
            this.txtSalarioProfessor.TabIndex = 4;
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarProfessor.Location = new System.Drawing.Point(79, 137);
            this.btnSalvarProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(56, 19);
            this.btnSalvarProfessor.TabIndex = 5;
            this.btnSalvarProfessor.Text = "Salvar";
            this.btnSalvarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProfessor
            // 
            this.btnCancelarProfessor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarProfessor.Location = new System.Drawing.Point(140, 137);
            this.btnCancelarProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarProfessor.Name = "btnCancelarProfessor";
            this.btnCancelarProfessor.Size = new System.Drawing.Size(64, 19);
            this.btnCancelarProfessor.TabIndex = 6;
            this.btnCancelarProfessor.Text = "Cancelar";
            this.btnCancelarProfessor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 2);
            this.panel1.TabIndex = 7;
            // 
            // cbxTurno
            // 
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino\t",
            "Noturno"});
            this.cbxTurno.Location = new System.Drawing.Point(11, 99);
            this.cbxTurno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(93, 21);
            this.cbxTurno.TabIndex = 8;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 167);
            this.ControlBox = false;
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelarProfessor);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.txtSalarioProfessor);
            this.Controls.Add(this.mskTelefoneProfessor);
            this.Controls.Add(this.mskCPFProfessor);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProfessor";
            this.Load += new System.EventHandler(this.FormProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.MaskedTextBox mskCPFProfessor;
        private System.Windows.Forms.MaskedTextBox mskTelefoneProfessor;
        private System.Windows.Forms.TextBox txtSalarioProfessor;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.Button btnCancelarProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTurno;
    }
}