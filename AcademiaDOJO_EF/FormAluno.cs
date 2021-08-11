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
    public partial class FormAluno : Form
    {
        Aluno aluno;
        public FormAluno(Aluno _aluno)
        {
            InitializeComponent();
            aluno = _aluno;
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            txtNome.DataBindings.Add("Text", aluno, "Nome");
            mskCPF.DataBindings.Add("Text", aluno, "CPF");
            mskTelefone.DataBindings.Add("Text", aluno, "Telefone");
            mskCPF.Enabled = String.IsNullOrEmpty(aluno.CPF);
        }
    }
}
