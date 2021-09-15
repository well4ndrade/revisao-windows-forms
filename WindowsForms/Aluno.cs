using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeAlunoMedia
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public double Media { get { return this.calculaMedia(); } }
        public string Situacao { get { return this.calculaSituacao(); } }

        public static List<Aluno> Alunos = new List<Aluno>();

        private List<double> notas;
        public List<double> Notas
        {
            get
            {
                if (this.notas == null) this.notas = new List<double>();
                return this.notas;
            }
            set
            {
                this.notas = value;
            }
        }

        private double calculaMedia()
        {
            double somaNotas = 0;
            foreach (var nota in this.Notas)
            {
                somaNotas += nota;
            }

            return somaNotas / this.Notas.Count;
        }

        private string calculaSituacao()
        {
            return this.calculaMedia() >= 7 ? "Aprovado" : "Reprovado";
        }
    }
}