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
    public partial class FormCadastroAluno : MaterialForm
    {
        string alunosFilename = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;
        public FormCadastroAluno()
        {
            InitializeComponent();
        }
        public bool verificarVazio()
        {
            bool ret = true;
            if (string.IsNullOrEmpty(TextMatricula.Text))
            {
                MessageBox.Show("Matrícula Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (!DateTime.TryParse(TextNascimento.Text, out _))
            {
                MessageBox.Show("Nascimento Obrigatório!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextNome.Text))
            {
                MessageBox.Show("Nome Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextEndereco.Text))
            {
                MessageBox.Show("Endereço Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextBairro.Text))
            {
                MessageBox.Show("Bairro Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextCidade.Text))
            {
                MessageBox.Show("Cidade Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(ComboEstado.Text))
            {
                MessageBox.Show("Estado Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
                ret = false;
            }
            else if (string.IsNullOrEmpty(TextSenha.Text))
            {
                MessageBox.Show("Senha Obrigatória!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextMatricula.Focus();
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
            var line = $"{TextMatricula.Text};" +
                        $"{TextNascimento.Text};" +
                        $"{TextNome.Text};" +
                        $"{TextEndereco.Text};" +
                        $"{TextBairro.Text};" +
                        $"{TextCidade.Text};" +
                        $"{ComboEstado.Text};" +
                        $"{TextSenha.Text}";

            // novo registro
            if (!isAlteracao)
            {
                var file = new StreamWriter(alunosFilename, true);
                file.WriteLine(line);
                file.Close();
            }
            else // altera valor existente
            {
                string[] alunos = File.ReadAllLines(alunosFilename);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(alunosFilename, alunos);
            }
            LimpaCampos();
        }
        private void Editar()
        {
            if (mlvAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = mlvAlunos.SelectedItems[0];
                TextMatricula.Text = item.SubItems[0].Text;
                TextNascimento.Text = item.SubItems[1].Text;
                TextNome.Text = item.SubItems[2].Text;
                TextEndereco.Text = item.SubItems[3].Text;
                TextBairro.Text = item.SubItems[4].Text;
                ComboEstado.Text = item.SubItems[5].Text;
                TextCidade.Text = item.SubItems[6].Text;
                TextSenha.Text = item.SubItems[7].Text;

                TabControlCadastro.SelectedIndex = 0;
                TextMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecionar algum aluno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvAlunos.Columns.Clear();
            mlvAlunos.Items.Clear();
            mlvAlunos.Columns.Add("Matricula");
            mlvAlunos.Columns.Add("Data Nasc.");
            mlvAlunos.Columns.Add("Nome");
            mlvAlunos.Columns.Add("Endereço");
            mlvAlunos.Columns.Add("Bairro");
            mlvAlunos.Columns.Add("Cidade");
            mlvAlunos.Columns.Add("UF");

            string[] alunos = File.ReadAllLines(alunosFilename);

            foreach (string aluno in alunos)
            {
                var campos = aluno.Split(';');
                mlvAlunos.Items.Add(new ListViewItem(campos));
            }
            mlvAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }
        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        private void Excluir()
        {
            List<String> alunos = File.ReadAllLines(alunosFilename).ToList();
            alunos.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunosFilename, alunos);
        }
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
        private void mlvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TextMatricula.Focus();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mlvAlunos.SelectedIndices.Count > 0) 
            {
                if (MessageBox.Show(this, "Deseja realmente deletar o aluno selecionado?", "Pergunta", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvAlunos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecionar algum aluno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
