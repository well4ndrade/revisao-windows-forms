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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var formCadastro = new Form2(this);
            formCadastro.Show();
        }

        public void PreencheGridDeAlunos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Aluno.Alunos;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheGridDeAlunos();
        }
    }
}
