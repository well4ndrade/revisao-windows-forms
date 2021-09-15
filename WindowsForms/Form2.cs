using atividadeAlunoMedia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno()
            {
                Id = Aluno.Alunos.Count + 1,
                Nome = txtNome.Text,
                Matricula = txtMatricula.Text
            };
            aluno.Notas.Add(Convert.ToDouble(txtNota1.Text));
            aluno.Notas.Add(Convert.ToDouble(txtNota2.Text));
            aluno.Notas.Add(Convert.ToDouble(txtNota3.Text));
            aluno.Notas.Add(Convert.ToDouble(txtNota4.Text));

            Aluno.Alunos.Add(aluno);

            form1.PreencheGridDeAlunos();

            MessageBox.Show("O aluno foi cadastrado com sucesso");
            this.Close();
        }
    }
}
