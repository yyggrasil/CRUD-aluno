using ReaLTaiizor.Forms;

namespace CRUD_aluno
{
    public partial class Cadastro : MaterialForm
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        public void cadastrarmAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCurso formCurso = new FormCadastroCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}
