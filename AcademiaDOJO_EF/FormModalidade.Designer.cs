
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
            this.txtVezesSemanaModalidade = new System.Windows.Forms.TextBox();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarModalidade
            // 
            this.btnCancelarModalidade.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarModalidade.Location = new System.Drawing.Point(141, 132);
            this.btnCancelarModalidade.Name = "btnCancelarModalidade";
            this.btnCancelarModalidade.Size = new System.Drawing.Size(86, 23);
            this.btnCancelarModalidade.TabIndex = 18;
            this.btnCancelarModalidade.Text = "Cancelar";
            this.btnCancelarModalidade.UseVisualStyleBackColor = true;
            // 
            // btnSalvarModalidade
            // 
            this.btnSalvarModalidade.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarModalidade.Location = new System.Drawing.Point(60, 132);
            this.btnSalvarModalidade.Name = "btnSalvarModalidade";
            this.btnSalvarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarModalidade.TabIndex = 17;
            this.btnSalvarModalidade.Text = "Salvar";
            this.btnSalvarModalidade.UseVisualStyleBackColor = true;
            // 
            // txtPrecoHoraModalidade
            // 
            this.txtPrecoHoraModalidade.Location = new System.Drawing.Point(125, 87);
            this.txtPrecoHoraModalidade.Name = "txtPrecoHoraModalidade";
            this.txtPrecoHoraModalidade.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoHoraModalidade.TabIndex = 15;
            // 
            // txtVezesSemanaModalidade
            // 
            this.txtVezesSemanaModalidade.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.txtVezesSemanaModalidade.Location = new System.Drawing.Point(125, 55);
            this.txtVezesSemanaModalidade.Name = "txtVezesSemanaModalidade";
            this.txtVezesSemanaModalidade.Size = new System.Drawing.Size(100, 22);
            this.txtVezesSemanaModalidade.TabIndex = 13;
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(125, 24);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(100, 22);
            this.txtNomeModalidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vezes Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(AcademiaDOJO_EF.Dominio.Modalidade);
            // 
            // FormModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarModalidade);
            this.Controls.Add(this.btnSalvarModalidade);
            this.Controls.Add(this.txtPrecoHoraModalidade);
            this.Controls.Add(this.txtVezesSemanaModalidade);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModalidade";
            this.Load += new System.EventHandler(this.FormModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.Button btnCancelarModalidade;
        private System.Windows.Forms.Button btnSalvarModalidade;
        private System.Windows.Forms.TextBox txtPrecoHoraModalidade;
        private System.Windows.Forms.TextBox txtVezesSemanaModalidade;
        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}