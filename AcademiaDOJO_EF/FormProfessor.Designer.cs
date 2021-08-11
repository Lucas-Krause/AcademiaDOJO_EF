
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
            this.txtTurnoProfessor = new System.Windows.Forms.TextBox();
            this.mskCPFProfessor = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefoneProfessor = new System.Windows.Forms.MaskedTextBox();
            this.txtSalarioProfessor = new System.Windows.Forms.TextBox();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.btnCancelarProfessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salário";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(81, 9);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProfessor.TabIndex = 0;
            // 
            // txtTurnoProfessor
            // 
            this.txtTurnoProfessor.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.txtTurnoProfessor.Location = new System.Drawing.Point(81, 95);
            this.txtTurnoProfessor.Name = "txtTurnoProfessor";
            this.txtTurnoProfessor.Size = new System.Drawing.Size(100, 22);
            this.txtTurnoProfessor.TabIndex = 3;
            // 
            // mskCPFProfessor
            // 
            this.mskCPFProfessor.Location = new System.Drawing.Point(81, 37);
            this.mskCPFProfessor.Mask = "000,000,000-00";
            this.mskCPFProfessor.Name = "mskCPFProfessor";
            this.mskCPFProfessor.Size = new System.Drawing.Size(100, 22);
            this.mskCPFProfessor.TabIndex = 1;
            // 
            // mskTelefoneProfessor
            // 
            this.mskTelefoneProfessor.Location = new System.Drawing.Point(81, 67);
            this.mskTelefoneProfessor.Mask = "(00)00000-0000";
            this.mskTelefoneProfessor.Name = "mskTelefoneProfessor";
            this.mskTelefoneProfessor.Size = new System.Drawing.Size(100, 22);
            this.mskTelefoneProfessor.TabIndex = 2;
            // 
            // txtSalarioProfessor
            // 
            this.txtSalarioProfessor.Location = new System.Drawing.Point(81, 127);
            this.txtSalarioProfessor.Name = "txtSalarioProfessor";
            this.txtSalarioProfessor.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioProfessor.TabIndex = 4;
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarProfessor.Location = new System.Drawing.Point(14, 170);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProfessor.TabIndex = 5;
            this.btnSalvarProfessor.Text = "Salvar";
            this.btnSalvarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProfessor
            // 
            this.btnCancelarProfessor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarProfessor.Location = new System.Drawing.Point(95, 170);
            this.btnCancelarProfessor.Name = "btnCancelarProfessor";
            this.btnCancelarProfessor.Size = new System.Drawing.Size(86, 23);
            this.btnCancelarProfessor.TabIndex = 6;
            this.btnCancelarProfessor.Text = "Cancelar";
            this.btnCancelarProfessor.UseVisualStyleBackColor = true;
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 209);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarProfessor);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.txtSalarioProfessor);
            this.Controls.Add(this.mskTelefoneProfessor);
            this.Controls.Add(this.mskCPFProfessor);
            this.Controls.Add(this.txtTurnoProfessor);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtTurnoProfessor;
        private System.Windows.Forms.MaskedTextBox mskCPFProfessor;
        private System.Windows.Forms.MaskedTextBox mskTelefoneProfessor;
        private System.Windows.Forms.TextBox txtSalarioProfessor;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.Button btnCancelarProfessor;
    }
}