using AcademiaDOJO_EF.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaDOJO_EF
{
    public partial class FormProfessor : Form
    {
        Professor professor;
        public FormProfessor(Professor _professor)
        {
            InitializeComponent();
            professor = _professor;
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            txtNomeProfessor.DataBindings.Add("Text", professor, "Nome");
            txtSalarioProfessor.DataBindings.Add("Text", professor, "SalarioHora");
            txtTurnoProfessor.DataBindings.Add("Text", professor, "Turno");
            mskTelefoneProfessor.DataBindings.Add("Text", professor, "Telefone");
            mskCPFProfessor.DataBindings.Add("Text", professor, "CPF");

            mskCPFProfessor.ReadOnly = !String.IsNullOrEmpty(professor.CPF);
        }
    }
}
