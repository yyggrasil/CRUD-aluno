namespace CRUD_aluno
{
    partial class FormCadastroCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            ComboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            ComboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            TextDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ComboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            TextCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            mlvCursos = new ReaLTaiizor.Controls.MaterialListView();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(719, 342);
            TabControlCadastro.TabIndex = 1;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(ComboPeriodo);
            tabPageCadastro.Controls.Add(ComboNivel);
            tabPageCadastro.Controls.Add(ButtonSalvar);
            tabPageCadastro.Controls.Add(ButtonCancelar);
            tabPageCadastro.Controls.Add(TextDuracao);
            tabPageCadastro.Controls.Add(TextNome);
            tabPageCadastro.Controls.Add(ComboArea);
            tabPageCadastro.Controls.Add(TextCodigo);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(711, 307);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // ComboPeriodo
            // 
            ComboPeriodo.AutoResize = false;
            ComboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            ComboPeriodo.Depth = 0;
            ComboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            ComboPeriodo.DropDownHeight = 174;
            ComboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPeriodo.DropDownWidth = 121;
            ComboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboPeriodo.FormattingEnabled = true;
            ComboPeriodo.Hint = "Perído";
            ComboPeriodo.IntegralHeight = false;
            ComboPeriodo.ItemHeight = 43;
            ComboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            ComboPeriodo.Location = new Point(21, 180);
            ComboPeriodo.MaxDropDownItems = 4;
            ComboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboPeriodo.Name = "ComboPeriodo";
            ComboPeriodo.Size = new Size(332, 49);
            ComboPeriodo.StartIndex = 0;
            ComboPeriodo.TabIndex = 11;
            // 
            // ComboNivel
            // 
            ComboNivel.AutoResize = false;
            ComboNivel.BackColor = Color.FromArgb(255, 255, 255);
            ComboNivel.Depth = 0;
            ComboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            ComboNivel.DropDownHeight = 174;
            ComboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboNivel.DropDownWidth = 121;
            ComboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboNivel.FormattingEnabled = true;
            ComboNivel.Hint = "Nível";
            ComboNivel.IntegralHeight = false;
            ComboNivel.ItemHeight = 43;
            ComboNivel.Items.AddRange(new object[] { "Superior", "Técnico" });
            ComboNivel.Location = new Point(21, 125);
            ComboNivel.MaxDropDownItems = 4;
            ComboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboNivel.Name = "ComboNivel";
            ComboNivel.Size = new Size(472, 49);
            ComboNivel.StartIndex = -1;
            ComboNivel.TabIndex = 10;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSize = false;
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(587, 238);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(106, 48);
            ButtonSalvar.TabIndex = 0;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.AutoSize = false;
            ButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancelar.Depth = 0;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(472, 238);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(111, 48);
            ButtonCancelar.TabIndex = 9;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // TextDuracao
            // 
            TextDuracao.AnimateReadOnly = false;
            TextDuracao.AutoCompleteMode = AutoCompleteMode.None;
            TextDuracao.AutoCompleteSource = AutoCompleteSource.None;
            TextDuracao.BackgroundImageLayout = ImageLayout.None;
            TextDuracao.CharacterCasing = CharacterCasing.Normal;
            TextDuracao.Depth = 0;
            TextDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextDuracao.HideSelection = true;
            TextDuracao.Hint = "Duração em semestres";
            TextDuracao.LeadingIcon = null;
            TextDuracao.Location = new Point(499, 126);
            TextDuracao.MaxLength = 32767;
            TextDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextDuracao.Name = "TextDuracao";
            TextDuracao.PasswordChar = '\0';
            TextDuracao.PrefixSuffixText = null;
            TextDuracao.ReadOnly = false;
            TextDuracao.RightToLeft = RightToLeft.No;
            TextDuracao.SelectedText = "";
            TextDuracao.SelectionLength = 0;
            TextDuracao.SelectionStart = 0;
            TextDuracao.ShortcutsEnabled = true;
            TextDuracao.Size = new Size(194, 48);
            TextDuracao.TabIndex = 5;
            TextDuracao.TabStop = false;
            TextDuracao.TextAlign = HorizontalAlignment.Left;
            TextDuracao.TrailingIcon = null;
            TextDuracao.UseSystemPasswordChar = false;
            // 
            // TextNome
            // 
            TextNome.AnimateReadOnly = false;
            TextNome.AutoCompleteMode = AutoCompleteMode.None;
            TextNome.AutoCompleteSource = AutoCompleteSource.None;
            TextNome.BackgroundImageLayout = ImageLayout.None;
            TextNome.CharacterCasing = CharacterCasing.Normal;
            TextNome.Depth = 0;
            TextNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNome.HideSelection = true;
            TextNome.Hint = "Nome";
            TextNome.LeadingIcon = null;
            TextNome.Location = new Point(21, 72);
            TextNome.MaxLength = 32767;
            TextNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNome.Name = "TextNome";
            TextNome.PasswordChar = '\0';
            TextNome.PrefixSuffixText = null;
            TextNome.ReadOnly = false;
            TextNome.RightToLeft = RightToLeft.No;
            TextNome.SelectedText = "";
            TextNome.SelectionLength = 0;
            TextNome.SelectionStart = 0;
            TextNome.ShortcutsEnabled = true;
            TextNome.Size = new Size(672, 48);
            TextNome.TabIndex = 3;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // ComboArea
            // 
            ComboArea.AutoResize = false;
            ComboArea.BackColor = Color.FromArgb(255, 255, 255);
            ComboArea.Depth = 0;
            ComboArea.DrawMode = DrawMode.OwnerDrawVariable;
            ComboArea.DropDownHeight = 174;
            ComboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboArea.DropDownWidth = 121;
            ComboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboArea.FormattingEnabled = true;
            ComboArea.Hint = "Área";
            ComboArea.IntegralHeight = false;
            ComboArea.ItemHeight = 43;
            ComboArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Industria", "Administração" });
            ComboArea.Location = new Point(359, 180);
            ComboArea.MaxDropDownItems = 4;
            ComboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboArea.Name = "ComboArea";
            ComboArea.Size = new Size(334, 49);
            ComboArea.StartIndex = 0;
            ComboArea.TabIndex = 7;
            // 
            // TextCodigo
            // 
            TextCodigo.AnimateReadOnly = false;
            TextCodigo.AutoCompleteMode = AutoCompleteMode.None;
            TextCodigo.AutoCompleteSource = AutoCompleteSource.None;
            TextCodigo.BackgroundImageLayout = ImageLayout.None;
            TextCodigo.CharacterCasing = CharacterCasing.Normal;
            TextCodigo.Depth = 0;
            TextCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCodigo.HideSelection = true;
            TextCodigo.Hint = "Código do curso";
            TextCodigo.LeadingIcon = null;
            TextCodigo.Location = new Point(21, 18);
            TextCodigo.MaxLength = 32767;
            TextCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCodigo.Name = "TextCodigo";
            TextCodigo.PasswordChar = '\0';
            TextCodigo.PrefixSuffixText = null;
            TextCodigo.ReadOnly = false;
            TextCodigo.RightToLeft = RightToLeft.No;
            TextCodigo.SelectedText = "";
            TextCodigo.SelectionLength = 0;
            TextCodigo.SelectionStart = 0;
            TextCodigo.ShortcutsEnabled = true;
            TextCodigo.Size = new Size(672, 48);
            TextCodigo.TabIndex = 1;
            TextCodigo.TabStop = false;
            TextCodigo.TextAlign = HorizontalAlignment.Left;
            TextCodigo.TrailingIcon = null;
            TextCodigo.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(mlvCursos);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(711, 307);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(473, 262);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(545, 262);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(624, 262);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // mlvCursos
            // 
            mlvCursos.AutoSizeTable = false;
            mlvCursos.BackColor = Color.FromArgb(255, 255, 255);
            mlvCursos.BorderStyle = BorderStyle.None;
            mlvCursos.Depth = 0;
            mlvCursos.FullRowSelect = true;
            mlvCursos.Location = new Point(3, 3);
            mlvCursos.MinimumSize = new Size(200, 100);
            mlvCursos.MouseLocation = new Point(-1, -1);
            mlvCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvCursos.Name = "mlvCursos";
            mlvCursos.OwnerDraw = true;
            mlvCursos.Size = new Size(702, 250);
            mlvCursos.TabIndex = 0;
            mlvCursos.UseCompatibleStateImageBehavior = false;
            mlvCursos.View = View.Details;
            mlvCursos.Enter += mlvCursos_Enter;
            mlvCursos.MouseDoubleClick += mlvCursos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 409);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextDuracao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialComboBox ComboArea;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCodigo;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialListView mlvCursos;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox ComboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox ComboNivel;
    }
}