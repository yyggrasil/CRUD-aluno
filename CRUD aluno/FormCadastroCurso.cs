using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_aluno
{
    public partial class FormCadastroCurso : MaterialForm
    {
        string cursosFilename = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroCurso()
        {
            InitializeComponent();
        }
        //  FUNÇÕES
        private bool verificarVazio()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(TextCodigo.Text))
            {
                MessageBox.Show("Código Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboNivel.Text))
            {
                MessageBox.Show("Nível Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextDuracao.Text))
            {
                MessageBox.Show("Duração Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboPeriodo.Text))
            {
                MessageBox.Show("Período Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboArea.Text))
            {
                MessageBox.Show("Estado Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextCodigo.Focus();
                ret = false;
            }
            return ret;
        }
        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
        private void Salvar()
        {
            var line = $"{TextCodigo.Text};" +
                        $"{TextNome.Text};" +
                        $"{ComboNivel.Text};" +
                        $"{TextDuracao.Text};" +
                        $"{ComboPeriodo.Text};" +
                        $"{ComboArea.Text}";

            // novo registro
            if (!isAlteracao)
            {
                var file = new StreamWriter(cursosFilename, true);
                file.WriteLine(line);
                file.Close();
            }
            else // altera valor existente
            {
                string[] cursos = File.ReadAllLines(cursosFilename);
                cursos[indexSelecionado] = line;
                File.WriteAllLines(cursosFilename, cursos);
            }
            LimpaCampos();
        }
        private void Editar()
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var Item = mlvCursos.SelectedItems[0];

                TextCodigo.Text = Item.SubItems[0].Text;
                TextNome.Text = Item.SubItems[1].Text;
                ComboNivel.Text = Item.SubItems[2].Text;
                TextDuracao.Text = Item.SubItems[3].Text;
                ComboPeriodo.Text = Item.SubItems[4].Text;
                ComboArea.Text = Item.SubItems[5].Text;

                TabControlCadastro.SelectedIndex = 0;
                TextCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecionar algum Curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvCursos.Columns.Clear();
            mlvCursos.Items.Clear();
            mlvCursos.Columns.Add("Código");
            mlvCursos.Columns.Add("Nome");
            mlvCursos.Columns.Add("Nível");
            mlvCursos.Columns.Add("duração");
            mlvCursos.Columns.Add("Período");
            mlvCursos.Columns.Add("Área");
            if (!File.Exists(cursosFilename))
            {
                File.OpenWrite(cursosFilename);
            }
            string[] cursos = File.ReadAllLines(cursosFilename);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(';');
                mlvCursos.Items.Add(new ListViewItem(campos));
            }
            mlvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }
        private void Excluir()
        {
            List<String> cursos = File.ReadAllLines(cursosFilename).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFilename, cursos);
        }
        //  EVENTOS
        //      CADASTRO
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas.\r\n" +
                "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }
        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            if (verificarVazio())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }
        //      CONSULTA
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TextCodigo.Focus();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mlvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o curso selecionado?", "Pergunta", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecionar algum curso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void mlvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void mlvCursos_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }
    }
}
